using UnityEngine;
using System.Collections;

public class GeradorDeCenario : MonoBehaviour {

	public Block prefab;

	void Start () {
		StartCoroutine (Criacao ());
	}

	IEnumerator Criacao(){
		Block lastBlock = null;

		//cria 20 blocos a esquerda pra preencher toda tela
		for (int i = -20; i <= 0; i++) {
			Vector3 pos = this.transform.position;
			pos += new Vector3 (i, 0, 0);
			lastBlock = (Block)Instantiate (prefab, pos, Quaternion.identity);
		}

		while (true) {
			//espera o ultimo bloco mover 1m
			yield return new WaitWhile (() => lastBlock.transform.position.x > this.transform.position.x-1);

			//cria 1 novo bloco 1m a direita do ultimo bloco
			Vector3 pos = lastBlock.transform.position + new Vector3 (1, 0, 0);
			lastBlock = (Block)Instantiate (prefab, pos, Quaternion.identity);
		}
	}

}
