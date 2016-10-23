using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {
	
	void Update () {
		//destroi block quando fica muito a esquerda da tela
		float camHorizontalSize = Camera.main.orthographicSize * Camera.main.aspect;
		if (this.transform.position.x < -camHorizontalSize - 2) {
			Destroy (this.gameObject);
		}
	}


	void FixedUpdate () {
		//mantem KinematicRigibody se movendo para esquerda
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		Vector2 pos = 
			rb.position +
			new Vector2 (-2, 0) * Time.fixedDeltaTime;
		rb.MovePosition (pos);
	}
	
}
