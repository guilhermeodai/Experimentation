using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class SettingsMenu : MonoBehaviour {

	[SerializeField] AudioMixer audioMixer;
	[SerializeField] TMP_Dropdown resolutionDropdown;
	Resolution[] availableResolutions;

	// Use this for initialization
	void Start () {
		ResolutionList ();
	}

	void ResolutionList () {
		availableResolutions = Screen.resolutions;
		resolutionDropdown.ClearOptions ();
		List<string> options = new List<string>	();
		int currentResolutionIndex = 0;
		for (int i = 0; i < availableResolutions.Length; i++) {
			string option = availableResolutions[i].width + "x" + availableResolutions[i].height;
			options.Add(option);
			if (availableResolutions[i].width == Screen.currentResolution.width && availableResolutions[i].height == Screen.currentResolution.height) {
				currentResolutionIndex = i;
			}
		}
		resolutionDropdown.AddOptions (options);
		resolutionDropdown.value = currentResolutionIndex;
		resolutionDropdown.RefreshShownValue ();
	}

	/* ---------------
	   AUDIO SETTINGS
	   --------------- */
	public void SetMasterVolume (float volume) {
		audioMixer.SetFloat ("MasterVolume", Mathf.Log (volume) * 20);
	}

	public void SetMusicVolume (float volume) {
		audioMixer.SetFloat ("MusicVolume", Mathf.Log (volume) * 20);
	}

	public void SetSFXVolume (float volume) {
		audioMixer.SetFloat ("SFXVolume", Mathf.Log (volume) * 20);
	}

	/* ---------------
	   VIDEO SETTINGS
	   --------------- */
	public void SetResolution (int resolutionIndex) {
		Resolution myResolution = availableResolutions[resolutionIndex];
		Screen.SetResolution (myResolution.width, myResolution.height, Screen.fullScreen);	
	}

	public void SetFullscreen (bool isFullscreen) {
		Screen.fullScreen = isFullscreen;
	}

	public void SetGraphicsQuality (int qualityIndex) {
		QualitySettings.SetQualityLevel (qualityIndex);
	}

	/* ---------------
	   SAVE SETTINGS
	   --------------- */
	public void SaveSettings () {
		
	}

}
