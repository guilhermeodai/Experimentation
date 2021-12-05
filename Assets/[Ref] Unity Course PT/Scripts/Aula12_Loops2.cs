using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula12_Loops2 : MonoBehaviour {

	// FOR - SINTAXE BÁSICA
	// for (tipoDeVariável nomeDaVariável = valorInicial; condição; incremento) { comandos a executar }
	// for (int i = 0; i <= 10; i++) { } --> para i (inteiro) igual a 0 até i menor ou igual a 10 acrescente i+1

	// FOREACH - SINTAXE BÁSICA
	// for (tipoDeVariável variávelLocal in nomeDoArray) { comandos a executar }
	// foreach (string s in textos) { } --> para cada string (s), dentro da array de strings textos
	// uma estrutura foreach executa uma série de instruções para cada elemento de uma coleção de objetos (array ou objeto IEnumerable)
	// ao contrário de uma estrutura for, ela não pode ser utilizada para adicionar ou remover elementos da coleção

	public string[] textos;

	// Use this for initialization
	void Start () {
		/* for (int local = 1; local <= 10; local++) {
			int display = local * 3;
			Debug.Log (display);
		} */

		for (int indice = 0; indice < textos.Length; indice++) {
			print (textos[indice]);
		}

		foreach (string s in textos) {
			print (s);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}