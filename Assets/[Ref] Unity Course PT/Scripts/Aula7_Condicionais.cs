using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula7_Condicionais : MonoBehaviour {

	// IF - SINTAXE BÁSICA
	// uma condição corresponde a uma variável bool, essencialmente
	// if (condição == true) { comandos a executar }
	// if (condição) { comandos a executar }  --> sintaxe simplificada para condição == true
	// if (!condição) { comandos a executar } --> sintaxe simplificada para condição == false ou condição != true

	// OPERADORES BOOLEANOS
	// os operadores booleanos são usados não para atribuir valor a uma variável, mas para comparar valores
	// == --> igual a
	// != --> diferente de
	// <= --> menor ou igual a
	// >= --> maior ou igual a
	// <  --> menor a
	// >  --> maior a

	// BOOL
	// uma variável bool pode ser definida com uma condição, no lugar de um valor true or false;

	public bool condition;
	public int idade;

	// Use this for initialization
	void Start () {
		if (condition == true) {
			idade = 0;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}