using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula8_Condicionais2 : MonoBehaviour {

	// ELSE
	// complementa a(s) condição(ões) original(is). Qualquer resultado não contemplado nas condições anteriores é aplicado ao else. Vem sempre por último na cadeia de condições
	// if (condição) {} else {}

	// ELSE IF
	// adiciona condições secundárias entre os comandos if e else.
	// if (condição A) {} else if (condição B) {} else if (condição C) {} else {}


	public int idade;
	public bool podeBeber, idadeInvalida;

	// Use this for initialization
	void Start () {
		if (idade >= 18) {
			podeBeber = true;
			idadeInvalida = false;
		} else if (idade < 0) {
			podeBeber = false;
			idadeInvalida = true;
		} else {
			podeBeber = false;
			idadeInvalida = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}