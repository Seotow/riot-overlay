import test from "node:test";
import assert from "node:assert/strict";
import { accountlessEnvironment } from "../Collector/runtime/accountless-environment";
test("accountless child cannot inherit LB/AWS/Cognito credentials or the user's env file", () => {
  const parent = {
    SystemRoot: "C:/Windows",
    TEMP: "C:/Temp",
    LB_EMAIL: "PRIVATE_SENTINEL",
    lb_password: "PRIVATE_SENTINEL",
    LB_CREDENTIAL_FILE: "real.env",
    AWS_ACCESS_KEY_ID: "PRIVATE_SENTINEL",
    AWS_SHARED_CREDENTIALS_FILE: "private.ini",
    BLUEBOTTLE_TOKEN: "PRIVATE_SENTINEL",
    COGNITO_REFRESH_TOKEN: "PRIVATE_SENTINEL",
    AMAZON_SESSION_TOKEN: "PRIVATE_SENTINEL",
  };
  const env = accountlessEnvironment(parent, "not-present.env");
  assert.equal(env.LB_EMAIL, "");
  assert.equal(env.LB_PASSWORD, "");
  assert.equal(env.LB_CREDENTIAL_FILE, "not-present.env");
  assert.equal(env.SystemRoot, parent.SystemRoot);
  assert.equal(env.TEMP, parent.TEMP);
  assert.ok(!JSON.stringify(env).includes("PRIVATE_SENTINEL"));
  assert.equal(parent.LB_CREDENTIAL_FILE, "real.env");
  assert.equal(parent.LB_EMAIL, "PRIVATE_SENTINEL");
});
