using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite1 : MonoBehaviour {

	public float velocidad = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A)) {
			Debug.Log ("Hemos pulsado la tecla Izquierda");
			transform.Translate (Vector2.left * velocidad * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.B)) {
			Debug.Log ("Hemos pulsado la tecla Derecha");
			transform.Translate (Vector2.right * velocidad * Time.deltaTime);
		}

		}	
		
	}

