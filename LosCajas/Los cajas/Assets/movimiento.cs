using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour {
	//debe coger el valor z de la camara y convertirlo en un valor y en este objeto que determinara hacia donde gira el objeto
	// debe tener un rozamiento 00 y solo mueve de izq a derecha

	Camara_giros cg;
	//public GameObject ski1, ski2;

	void Start () {
		cg = GameObject.Find ("Camera").GetComponent<Camara_giros> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
