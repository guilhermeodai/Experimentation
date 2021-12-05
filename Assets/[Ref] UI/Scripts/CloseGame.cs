using UnityEngine;
using System.Collections;

public class CloseGame : MonoBehaviour {

	public void Quit () {
		// Quits the game on the Unity Editor
		#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
		// Closes the game application on build versions
		#else
			Application.Quit ();
		#endif
	}
}
