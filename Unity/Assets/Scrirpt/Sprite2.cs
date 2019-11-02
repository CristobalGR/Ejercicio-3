using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite2 : MonoBehaviour {

	public float velocidad = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.C)) {
			Debug.Log ("Hemos pulsado la tecla Arriba");
			transform.Translate (Vector2.up * velocidad * Time.deltaTime);
		}	

		if (Input.GetKey (KeyCode.D)) {
			Debug.Log ("Hemos pulsado la tecla Abajo");
			transform.Translate (Vector2.down * velocidad * Time.deltaTime);
		
		}
   }
}
