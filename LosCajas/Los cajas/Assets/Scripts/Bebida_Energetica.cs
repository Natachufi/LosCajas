using UnityEngine;
using System.Collections;




public class Bebida_Energetica : MonoBehaviour
{
	bool bebida = false;
	Rigidbody rg;


	void Start()
	{
		rg = GetComponent<Rigidbody>();

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

			bebida=true;
			Destroy(objeto.gameObject,2);
		}
	}
}