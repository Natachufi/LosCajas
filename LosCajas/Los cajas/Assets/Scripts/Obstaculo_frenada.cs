using UnityEngine;
using System.Collections;

public class Obstaculo_frenada : MonoBehaviour 
{
	bool obstaculo = false;
	Rigidbody rg;
	
	void Start()
	{
		rg = GetComponent<Rigidbody>();
	}
	
	void Update()
	{
		if(obstaculo)
		{
			rg.AddForce(transform.forward/2000);
			obstaculo=false;
		}	
	}
	
	void OnCollisionEnter(Collision objeto)
	{
		if(objeto.transform.tag == "obstaculo")
		{
			obstaculo=true;
		}
	}
}