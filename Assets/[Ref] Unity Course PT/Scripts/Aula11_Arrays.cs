using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula11_Arrays : MonoBehaviour {

	// ARRAYS - SINTAXE BÁSICA
	// declara-se um array da mesma forma que uma variável, apenas acrescentando colchetes após o tipo da variável;
	// uma array permite que vários valores sejam armazenados em uma variável apenas, fazendo uso de um índice
	// para acessar o tamanho do índice do array --> nomeDoArray.Length

	public int[] inteiros;
	public int indice = 0;
	public int receptaculo;

	// Use this for initialization
	void Start () {
		//inteiros [0] = 20;
		//inteiros [1] = -5;

		while (indice < inteiros.Length) {
			inteiros [indice] = indice * 2;
			indice++;
		}
		receptaculo = inteiros [4];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}