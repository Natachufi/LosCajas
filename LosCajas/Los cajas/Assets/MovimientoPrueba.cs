using UnityEngine;
using System.Collections;

public class MovimientoPrueba : MonoBehaviour {
	public Transform Head;
	public Vector3 izq;
	public Vector3 drcha;
	Rigidbody rg;
	// Use this for initialization
	void Start () 
	{
		rg = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () 
	{

		//Debug.Log (Head.transform.rotation.eulerAngles.z);
		if (Head.rotation.eulerAngles.z <330 && Head.transform.rotation.eulerAngles.z >180)
		{
			Debug.Log ("derecha_bien");
			//Como los controles estan invertidos, el movimiento es al contrario cuando se llama.
			rg.AddForce(izq);

		}
		if (Head.rotation.eulerAngles.z >30 && Head.transform.rotation.eulerAngles.z <180)
		{
			Debug.Log ("izquierda_bien");
			//Como los controles estan invertidos, el movimiento es al contrario cuando se llama.
			rg.AddForce(drcha);

		}
		/*
		if(Head.rotation.eulerAngles.z >0 && Head.transform.rotation.eulerAngles.z <60)
		{
			transform.rotation = Quaternion.Lerp(Quaternion.Euler(0, 0, 0), Quaternion.Euler(0, 45, 0),(60*Head.transform.rotation.eulerAngles.z/10000));
		}
		if(Head.rotation.eulerAngles.z <360 && Head.transform.rotation.eulerAngles.z >270)
		{
			transform.rotation = Quaternion.Lerp(Quaternion.Euler(0, 0, 0), Quaternion.Euler(0, -45, 0),(-60*(Head.transform.rotation.eulerAngles.z-360)/10000));
		}

		if(Head.rotation.eulerAngles.z >0 && Head.transform.rotation.eulerAngles.z <30)
		{
			//Funciona Bien
			rg.velocity = Vector3.zero;
			rg.angularVelocity = Vector3.zero; 

		}
		if(Head.rotation.eulerAngles.z <360 && Head.transform.rotation.eulerAngles.z >330)
		{
			//Funciona Bien
			rg.velocity = Vector3.zero;
			rg.angularVelocity = Vector3.zero; 
			
		}
		*/


	}
}
