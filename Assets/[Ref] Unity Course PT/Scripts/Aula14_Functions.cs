using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula14_Functions : MonoBehaviour {

	// FUNÇÕES - SINTAXE BÁSICA
	// tipoDeRetorno NomeDaFunção (argumentos) { comandos a executar }

	public int latidos;
	public int valorA, valorB;
	public float resultado;

	// Start () é uma função executada apenas uma vez, na inicialização do script
	// A função Latir () é apenas executada
	// A função SomarImprimir () é executada desde que os parâmetros sejam devidamente 
	// A função Multiplicar () aqui é usada para atribuir o valor retornado por ela à variável resultado
	void Start () {
		Latir ();
		SomarImprimir (valorA, valorB);
		resultado = Multiplicar (valorA, valorB);
	}

	// Esta função é do tipo mais simples: não retorna valores ao sistema; também não requer argumentos, apenas executa instruções quando chamada pelo sistema
	void Latir () {
		print ("Au au!");
		latidos++;
	}

	// Esta função, por sua vez, necessita que 2 argumentos sejam declarados quando chamada pelo sistema para ser executada corretamente
	void SomarImprimir (float a, float b) {
		float soma = a + b;
		print ("O resultado da soma é " + soma);
	}

	// Esta função, além de requerer 2 argumentos, retorna ao sistema um valor, neste caso um float
	float Multiplicar (float x, float y) {
		float multiplicacao = x * y;
		return multiplicacao;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}