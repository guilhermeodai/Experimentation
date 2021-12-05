using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula9_Condicionais3 : MonoBehaviour {

	// OPERADORES LÓGICOS
	// && --> e
	// || --> ou

	public int idade;
	public bool idValida, podeComprar;

	// Use this for initialization
	void Start () {
		if ((idade >= 19 && idValida) || idade >= 35) {
			podeComprar = true;
		} else {
			podeComprar = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
