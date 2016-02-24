using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class choque_arbol : MonoBehaviour {

	private AudioSource sonido;

	// Use this for initialization
	void Start () {
		sonido = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void OnCollisionStay (Collision objeto){
		if (objeto.transform.tag == "Player") {
			sonido.Play ();
	
		}
	}
	

		
	

	void Update () {

	
	}
}
