using BlueBottleIPC.LeagueBroadcast.Scene;

namespace Farsight.Entity;

public readonly record struct ScriptValidationResponse(bool Completed, SceneScriptError? Error);
