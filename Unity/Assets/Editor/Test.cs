﻿using UnityEngine;
using UnityEditor;
using System.Collections;
using System.IO;

public static class Test {
	[MenuItem("Test/PreExport")]
	public static void PreExport() {
		Debug.Log (" >>> PreExport Method Started");

		string currentDirectory = Directory.GetCurrentDirectory ();
		Debug.Log (" >>> Current Directory: " + currentDirectory);
		string fileClass =
			"public class Generated { " + "\n" +
			"    public void Do() {" + "\n" +
			"        UnityEngine.Debug.Log(\"In Generated.Do!\");" + "\n" +
			"    }" + "\n" +
			"}";
		
		File.WriteAllText("Assets/Generated.cs", fileClass);
		Debug.Log (" >>> PreExport Method Ended");

	}

	[MenuItem("Test/PostExport")]
	public static void PostExport() {
		Debug.Log (" >>> PostExport Method Started");
		string asset = "Assets/Textures/WikiFun_Police_Smiley.png";
		Object assetObj = AssetDatabase.LoadMainAssetAtPath (asset);
		BuildPipeline.BuildAssetBundleExplicitAssetNames(
			new Object[] { assetObj } ,
			new string[] { "smile" },
			"smile.assetbundle"
		) ;
		Debug.Log (" >>> PostExport Method Ended");
	}
}
