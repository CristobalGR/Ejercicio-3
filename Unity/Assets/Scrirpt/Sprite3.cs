using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite3 : MonoBehaviour {

	public float velocidad = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.E)) {
			Debug.Log ("Hemos pulsado la tecla Izquierda");
			transform.Translate (Vector2.left * velocidad * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.F)) {
			Debug.Log ("Hemos pulsado la tecla Derecha");
			transform.Translate (Vector2.right * velocidad * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.G)) {
			Debug.Log ("Hemos pulsado la tecla Arriba");
			transform.Translate (Vector2.up * velocidad * Time.deltaTime);
		}	

		if (Input.GetKey (KeyCode.H)) {
			Debug.Log ("Hemos pulsado la tecla Abajo");
			transform.Translate (Vector2.down * velocidad * Time.deltaTime);
		}
    }
}