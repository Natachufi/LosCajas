using System;
using UnityEngine;

public class Camara : MonoBehaviour
{

	Rigidbody rb;
	public float accel = 100f;
	public float giro;
	public float ladeo;

		void Start ()
	{
	
		rb = GetComponent <Rigidbody> ();

	}
	
	void Update ()
	{
		GiraDch ();
		
		GiraIzq ();

		Acelera ();


	}

	void Acelera () {
		
		if (Input.GetKey (KeyCode.W)) {
			rb.AddForce (transform.forward * accel);
		}
	}
	void GiraIzq () {
		if (Input.GetKey (KeyCode.D)) {
			rb.AddForce (transform.right*giro);
			rb.transform.Rotate (new Vector3 (0f,0f,-ladeo));
			
		}
	}
	
	void GiraDch () {
		if (Input.GetKey (KeyCode.A)) {
			rb.AddForce (transform.right*-giro);
			rb.transform.Rotate (new Vector3 (0f,0f,ladeo));

		}
		
	}
}