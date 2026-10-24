import { defineConfig } from "vite";
import tailwindcss from "@tailwindcss/vite";
import { fileURLToPath, URL } from "node:url";
export default defineConfig({
  plugins: [tailwindcss()],
  resolve: { alias: { "@": fileURLToPath(new URL("./src", import.meta.url)) } },
  // Spectra Client, collector runtime, bundles và captures ghi file liên tục trong dự án. Dev server
  // theo dõi chúng vừa vô ích vừa làm Vite crash (EBUSY trên file tạm của profile) khi chạy module
  // Valorant cùng Studio, nên bỏ qua.
  server: {
    watch: {
      ignored: [
        "**/node_modules/**",
        "**/.git/**",
        "**/dist/**",
        "**/data/**",
        "**/collector/hosts/*/local/**",
        "**/collector/hosts/*/bundles/**",
        "**/collector/bundles/**",
        "**/collector/archive/**",
      ],
    },
  },
});
