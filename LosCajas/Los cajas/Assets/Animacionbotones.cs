﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Animacionbotones : MonoBehaviour {

	Animator anim;
	
	// Use this for initialization
	void Start () {
		
		anim = GetComponent <Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void parpadea (){
		
		anim.SetBool ("mirando", true);
		
	}
	
	public void noparpadea(){
		anim.SetBool ("mirando", false);
	}
}
