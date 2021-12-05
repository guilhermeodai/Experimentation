using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelTransitions : MonoBehaviour {

	[SerializeField] CanvasGroup[] panels = default;
	[SerializeField] [Range (0.1f, 5f)] float transitionDuration = 0.5f; // If the value is set to 0, it would cause an error


	// Use this for initialization
	void Start () {
		panels[0].gameObject.SetActive (true);
		panels[0].alpha = 1;
		panels[1].gameObject.SetActive (false);
		panels[1].alpha = 0;
	}

	public void BrowseIn () {		
		StartCoroutine (UIPanelTransition (panels[0], panels[1], transitionDuration));
	}

	public void BrowseOut () {		
		StartCoroutine (UIPanelTransition (panels[1], panels[0], transitionDuration));
	}
	
	IEnumerator UIPanelTransition (CanvasGroup panelA, CanvasGroup panelB, float duration) {
		float alphaA = panelA.alpha;
		float alphaB = panelB.alpha;
		float elapsedTime = 0;

		// float distance = (panelB.transform.position.z - panelA.transform.position.z) / 2;
		// Fade Out the active panel
		while (alphaA > 0) {
			elapsedTime += Time.deltaTime;
			alphaA -= Time.deltaTime / (duration / 2);
			panelA.alpha = alphaA;
			yield return null;
		}
		Debug.Log ("fade out done in " + elapsedTime + "s");
		// Deactivate the faded out panel and activate the one to be faded in
		panelA.gameObject.SetActive (false);
		panelB.gameObject.SetActive (true);
		// Reset the time counter
		elapsedTime = 0;
		// Fade In the next panel
		while (alphaB < 1) {
			elapsedTime += Time.deltaTime;
			alphaB += Time.deltaTime / (duration / 2);
			panelB.alpha = alphaB;
			yield return null;
		}
		Debug.Log ("fade in done in " + elapsedTime + "s");
	}
}