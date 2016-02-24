using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class sonido_velocidad : MonoBehaviour {
	private AudioSource sonido;

	// Use this for initialization
	void Start () {
		sonido = GetComponent<AudioSource> ();
	}

	void OnCollisionEnter (Collision objeto){

	if (objeto.transform.tag == "Player") {
			sonido.Play ();
			
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
