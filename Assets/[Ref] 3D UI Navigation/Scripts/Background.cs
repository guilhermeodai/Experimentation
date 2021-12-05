using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

	[SerializeField] Vector2 parallaxSpeed = Vector2.zero;

	Vector2 offset;
	Material texture;

	// Use this for initialization
	void Start () {
		// First we get a reference of the material applied to our quad background
		texture = GetComponent<Renderer> ().material;
		// Then we get the offset data from that material to know its starting position
		offset = texture.GetTextureOffset ("_MainTex");
	}
	
	// Update is called once per frame
	void Update () {
		// The offset value is increased
		offset += parallaxSpeed * Time.deltaTime;
		// Then the offset value is applied back to the material
		texture.SetTextureOffset ("_MainTex", offset);
	}
}
