using UnityEngine;
using System.Collections;
using System.IO;

public static class Test {
	public static void PreExport() {
		Debug.Log (" >>> PreExport Method Started");

		string currentDirectory = Directory.GetCurrentDirectory ();
		Debug.Log (" >>> Current Directory: " + currentDirectory);

		Debug.Log (" >>> PreExport Method Ended");

	}

	public static void PostExport() {
		Debug.Log (" >>> PostExport Method Started");
		Debug.Log (" >>> PostExport Method Ended");

	}
}
