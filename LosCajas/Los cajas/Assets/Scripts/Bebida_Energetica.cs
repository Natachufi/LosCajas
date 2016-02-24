using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]



public class Bebida_Energetica : MonoBehaviour
{
	bool bebida = false;
	Rigidbody rg;
	private AudioSource sonido;

	void Start()
	{
		rg = GetComponent<Rigidbody>();
		sonido = GetComponent<AudioSource> ();
	}

	void Update()
	{
		if(bebida)
		{
			rg.AddForce(transform.forward*2000);
			bebida=false;
		}	
	}

	void OnCollisionEnter(Collision objeto)
	{
		if(objeto.transform.tag == "bebida")
		{
			sonido.Play ();
			bebida=true;
			Destroy(objeto.gameObject);
		}
	}
}