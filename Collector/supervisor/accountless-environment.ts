// Isolate only the child. Never change the user's environment or credential file.
export function accountlessEnvironment(
  base: NodeJS.ProcessEnv,
  nonexistentCredentialFile: string,
): NodeJS.ProcessEnv {
  const env = { ...base };
  for (const key of Object.keys(env))
    if (/^(LB_|BLUEBOTTLE_|AWS_|AMAZON_|COGNITO_)/i.test(key)) delete env[key];
  // Empty (not absent) prevents DotEnv from filling these even if fallback code changes.
  env.LB_EMAIL = "";
  env.LB_PASSWORD = "";
  env.LB_CREDENTIAL_FILE = nonexistentCredentialFile;
  return env;
}
