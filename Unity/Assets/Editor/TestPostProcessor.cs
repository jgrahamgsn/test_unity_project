using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;

public class TestPostProcessor {

	[PostProcessBuildAttribute]
	public static void OnPostprocessBuild(BuildTarget target, string pathToBuiltProject) {
		Debug.Log (" >>> OnPostProcessBuild started");
		Debug.Log (" >>> target = " + target.ToString());
		Debug.Log (" >>> pathtoBuiltProject = " + pathToBuiltProject);
		Debug.Log (" >>> OnPostProcessBuild ended");
	}

	[PostProcessSceneAttribute]
	public static void OnPostprocessScene() { 
		Debug.Log (" >>> OnPostprocessScene started");
		Debug.Log (" >>> OnPostprocessScene ended");
	}

	[DidReloadScripts]
	public static void OnDidReloadScripts() {
		Debug.Log (" >>> OnDidReloadScripts started");
		Debug.Log (" >>> OnDidReloadScripts ended");
	}

}
