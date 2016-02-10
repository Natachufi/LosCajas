using UnityEngine;
using System.Collections;

public class Camara_giros : MonoBehaviour {
	Rigidbody rg;
	public float velocidadGiro = 5;
	public float giro = 20;
	public Transform target;
	// Use this for initialization
	void Start () {
		rg = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3 (target.position.x, target.position.y + 2, target.position.z);

		if (Input.GetKey (KeyCode.A)){
			rg.AddForce (transform.right*+giro);
			rg.transform.Rotate  (new Vector3 (0,0, velocidadGiro));
		}

		if (Input.GetKey (KeyCode.D)) {

			rg.AddForce (transform.right*-giro);
			rg.transform.Rotate  (new Vector3 (0,0, -velocidadGiro));
		}
	}
}
