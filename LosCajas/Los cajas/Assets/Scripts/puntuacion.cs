using UnityEngine;
using System.Collections;

public class puntuacion : MonoBehaviour {

	//poner script a elemento que va a dar puntos


	public int puntosquesuma; //puntos que añade
	private gestionpuntos gp;

	void OnTriggerEnter(Collider objeto){ 
		if(objeto.transform.tag == "Player"){
			gp = objeto.gameObject.GetComponent <gestionpuntos> ();
			gp.sumapuntos (puntosquesuma);
			Destroy (gameObject);

		}
	}

}
