#ifndef LC_READER_H
#define LC_READER_H

#include <stddef.h>
#include <stdint.h>

#if defined(_WIN32) && defined(LC_READER_BUILD)
#define LC_READER_API __declspec(dllexport)
#elif defined(_WIN32)
#define LC_READER_API __declspec(dllimport)
#else
#define LC_READER_API __attribute__((visibility("default")))
#endif

#ifdef __cplusplus
extern "C" {
#endif

#define LC_READER_API_VERSION 1u
#define LC_READER_ALLOW_FIXTURE 1u
#define LC_READER_ALLOW_UNVERIFIED 2u

typedef struct lc_reader lc_reader;

typedef enum lc_reader_result {
    LC_READER_OK = 0,
    LC_READER_INVALID_ARGUMENT = 1,
    LC_READER_INVALID_PROFILE = 2,
    LC_READER_TARGET_MISMATCH = 3,
    LC_READER_PROFILE_NOT_VERIFIED = 4,
    LC_READER_LIMIT_EXCEEDED = 5,
    LC_READER_INTERNAL_ERROR = 6,
    LC_READER_UNSUPPORTED_PLATFORM = 7
} lc_reader_result;

/* Return the number of bytes actually copied, never more than requested.
 * The callback and context must remain valid until lc_reader_destroy().
 * It must only read the target; no process writes or execution are required. */
typedef size_t (*lc_reader_read_fn)(void *context, uint64_t address,
                                  void *destination, size_t requested);

typedef struct lc_reader_target {
    uint32_t struct_size;
    const char *module_name;
    const char *version;
    const char *sha256;
    uint64_t module_base;
} lc_reader_target;

typedef struct lc_reader_request {
    uint32_t struct_size;
    const uint64_t *hero_addresses;
    size_t hero_count;
    /* 0 => discovery is unknown, output heroes:null; count must be zero.
     * 1 => caller supplied a known collection (an empty collection is []).
     * This core does not discover objects or assume a list/stride layout. */
    uint32_t heroes_known;
} lc_reader_request;

typedef struct lc_reader_error {
    int32_t code;
    char message[256];
} lc_reader_error;

LC_READER_API uint32_t lc_reader_api_version(void);

/* Target identity must be measured by the caller, not copied from the profile.
 * Module name, version and SHA-256 must all match. Fixture/static-derived
 * profiles require their explicit flags and are never runtime-verified. */
LC_READER_API int32_t lc_reader_create(
    const char *profile_json, size_t profile_length,
    const lc_reader_target *target, lc_reader_read_fn read_memory,
    void *read_context, uint32_t flags, lc_reader **out_reader,
    lc_reader_error *error);

/* Returned JSON buffers are UTF-8 and zero-terminated. out_length excludes
 * the final NUL. Free only with lc_reader_free_buffer(). The handle and
 * callback are not called concurrently by this library; callers must
 * serialize access to a shared handle. No target writes occur. */
LC_READER_API int32_t lc_reader_snapshot(
    lc_reader *reader, const lc_reader_request *request,
    char **out_json, size_t *out_length, lc_reader_error *error);

LC_READER_API int32_t lc_reader_profile_info(
    const lc_reader *reader, char **out_json, size_t *out_length,
    lc_reader_error *error);

LC_READER_API void lc_reader_free_buffer(char *buffer);
LC_READER_API void lc_reader_destroy(lc_reader *reader);

/* Optional Win32 adapter. It opens only PROCESS_VM_READ |
 * PROCESS_QUERY_LIMITED_INFORMATION. Process identity/module discovery and
 * pointer roots remain the caller's responsibility. On other platforms
 * open returns LC_READER_UNSUPPORTED_PLATFORM. close(NULL) is safe. */
LC_READER_API int32_t lc_reader_win32_open(uint32_t process_id,
                                          void **out_context,
                                          lc_reader_error *error);
LC_READER_API size_t lc_reader_win32_read(void *context, uint64_t address,
                                         void *destination, size_t requested);
LC_READER_API void lc_reader_win32_close(void *context);

#ifdef __cplusplus
}
#endif
#endif
