using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	//Update é executado a cada frame
	void Update () {
		//Captura tecla "Seta pra cima"
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			JumpPlayer ();
		}
	}

	//FixedUpdate é executado em sincronia com a física
	//Lugar correto de controlar velocidade
	void FixedUpdate () {
		//Manter velocidade x=0
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2 (0, rb.velocity.y);
	}

	void JumpPlayer (){
		//Se está encostando em algum outro collider (chão)
		if (this.GetComponent<Collider2D> ().IsTouchingLayers()) {
			//Pula com velocidade y=5
			Rigidbody2D rb = GetComponent<Rigidbody2D> ();
			rb.velocity = new Vector2 (rb.velocity.x, 5);
		}
	}

}
