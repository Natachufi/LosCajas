using UnityEngine;
using System.Collections;

public class barra_tiempo : MonoBehaviour {
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void activado(){
		gameObject.SetActive(true);
		anim.Play("barra_segundos");
		
	}
	public void desactivado(){ 
		gameObject.SetActive(false);
		
	}


}
