using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour {
	//debe coger el valor z de la camara y convertirlo en un valor y en este objeto que determinara hacia donde gira el objeto
	// debe tener un rozamiento 00 y solo mueve de izq a derecha
	Rigidbody rg;
	public Camara_giros cg;
	public float ladeado;
	public Vector3 izq;
	//public GameObject ski1, ski2;

	void Start () {
		cg = GameObject.Find ("Camera").GetComponent<Camara_giros> ();
		rg = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void MovimientoIzq(){
		Debug.Log (cg.transform.rotation.z);
		if (cg.transform.rotation.z <= 90 ) {
			Debug.Log("giro izq");
			rg.transform.Rotate  (izq);
		}
	}
	void MovimientoDrcha(){}

}
