using UnityEngine;
using UnityEditor;
using System.Collections;
using System.IO;
using System.Diagnostics;

public static class Test {
	public static string TestValue = string.Empty;

	[MenuItem("Test/PreExport")]
	public static void PreExport() {
		UnityEngine.Debug.Log (" >>> PreExport Method Started");
		UnityEngine.Debug.Log (" >>> PreExport Process ID: " + Process.GetCurrentProcess().Id);

		TestValue = "$$$$$$$$$$$$$$$$$";
		UnityEngine.Debug.Log (" >>> PreExport Static Test Value: " + TestValue);

		string currentDirectory = Directory.GetCurrentDirectory ();
		UnityEngine.Debug.Log (" >>> Current Directory: " + currentDirectory);
		string fileClass =
			"public class Generated { " + "\n" +
			"    public void Do() {" + "\n" +
			"        UnityEngine.Debug.Log(\"In Generated.Do!\");" + "\n" +
			"    }" + "\n" +
			"}";
		
		File.WriteAllText("Assets/Generated.cs", fileClass);
		UnityEngine.Debug.Log (" >>> PreExport Method Ended");

	}

	[MenuItem("Test/PostExport")]
	public static void PostExport() {
		UnityEngine.Debug.Log (" >>> PostExport Method Started");
		UnityEngine.Debug.Log (" >>> PostExport Process ID: " + Process.GetCurrentProcess().Id);
		UnityEngine.Debug.Log (" >>> PostExport Static Test Value: " + TestValue);

		string asset = "Assets/Textures/WikiFun_Police_Smiley.png";
		Object assetObj = AssetDatabase.LoadMainAssetAtPath (asset);
		BuildPipeline.BuildAssetBundleExplicitAssetNames(
			new Object[] { assetObj } ,
			new string[] { "smile" },
			"smile.assetbundle"
		) ;
		UnityEngine.Debug.Log (" >>> PostExport Method Ended");
	}
}
