using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {

	// Loads a new scene according to its index number on Build Settings
	public void LoadByIndex(int sceneIndex) {
		SceneManager.LoadScene (sceneIndex);
	}
}
