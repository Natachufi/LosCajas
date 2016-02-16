using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {

	public float accel = 100f;
	Rigidbody rb;
	public float giro;

	// Use this for initialization
	void Start () {
	
		rb = GetComponent <Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
	
		Acelera ();

		GiraDch ();

		GiraIzq ();
	
			

	
	}


	void Acelera () {

		if (Input.GetKey (KeyCode.W)) {
			rb.AddForce (transform.forward * accel);
		}
	}


	void GiraIzq () {
		if (Input.GetKey (KeyCode.A)) {
			rb.transform.Rotate (Vector3.right, -giro * Time.deltaTime);
			
		}
	}

	void GiraDch () {
		if (Input.GetKey (KeyCode.A)) {
			rb.transform.Rotate (Vector3.right, giro * Time.deltaTime);
			
		}

}
}