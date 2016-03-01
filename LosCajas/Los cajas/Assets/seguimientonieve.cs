using UnityEngine;
using System.Collections;

public class seguimientonieve : MonoBehaviour {

	public Rigidbody jugador;
	Rigidbody rg;

	// Use this for initialization
	void Start () {
	
		rg = GetComponent <Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
	

		rg.velocity = jugador.velocity;

	}
}
