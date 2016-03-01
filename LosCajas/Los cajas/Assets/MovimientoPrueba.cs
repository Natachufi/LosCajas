using UnityEngine;
using System.Collections;

public class MovimientoPrueba : MonoBehaviour {
	public Transform Head;
	public Vector3 izq;
	public Vector3 drcha;
	Rigidbody rg;
	// Use this for initialization
	void Start () {
		rg = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log (Head.transform.rotation.eulerAngles.z);
		if (Head.rotation.eulerAngles.z <330 && Head.transform.rotation.eulerAngles.z >180){
			Debug.Log ("derecha_bien");
			rg.AddForce(drcha);
		}
		if (Head.rotation.eulerAngles.z >30 && Head.transform.rotation.eulerAngles.z <180){
			Debug.Log ("izquierda_bien");
			rg.AddForce(izq);
		}
		if (Head.rotation.eulerAngles.z >0 && Head.transform.rotation.eulerAngles.z <30 &&(Head.transform.rotation.eulerAngles.z <330)){
			Debug.Log ("zona segura");
			rg.AddForce (Vector3.zero);
		}
		/*
		if (Head.rotation.eulerAngles.z >= 90) {
			transform.rotation.eulerAngles.z = 90;
		}
		*/
	}
}
