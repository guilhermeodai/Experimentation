using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula10_Loops : MonoBehaviour {

	// WHILE
	// enquanto uma condição for verdadeira, executa as ações em loop
	// while (condição == true) { comandos a executar }

	// DO WHILE
	// o mesmo que while, com a diferença que antes de verificar se a condição é verdadeira, executa os comandos 1 vez
	// do { comandos a executar } while (condição == true)

	public int inteiro, inteiro2;

	// Use this for initialization
	void Start () {
		while (inteiro < 100) {
			inteiro++;
			Debug.Log (inteiro);
		}

		do {
			inteiro2++;
			Debug.Log (inteiro2);
		} while (inteiro < 100);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}