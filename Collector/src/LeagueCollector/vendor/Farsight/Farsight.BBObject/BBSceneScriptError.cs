using System;
using BlueBottleIPC.LeagueBroadcast.Scene;

namespace Farsight.BBObject;

public class BBSceneScriptError(Scene scene, SceneScriptError scriptError) : EventArgs
{
	public Scene Scene { get; } = scene;

	public SceneScriptError ScriptError { get; } = scriptError;
}
