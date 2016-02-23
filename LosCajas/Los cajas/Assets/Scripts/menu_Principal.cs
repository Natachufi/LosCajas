using UnityEngine;
using System.Collections;

public class menu_Principal : MonoBehaviour {
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void grande() { //cuando el boton se hace grande
		anim.SetBool("mirando",true);
	
	}
	public void pequeno(){ //cuando el boton vuelve a su tamaño original
		anim.SetBool("mirando", false);
	}
}
