using UnityEngine;
using System.Collections;

public class menupausa : MonoBehaviour {

	private Animator anim;
	public float tiempo_mirada = 3f;
	float tiempo = 0;
	bool mirando = false;


	void Start () {

		anim = GetComponent<Animator> ();
	}
	

	void Update () {
	}


	public void oculta_menu(){

        if (mirando && tiempo < Time.time) {
			Time.timeScale = 1f;
			anim.SetBool ("mostrar", false);

		}
	}


	public void salir(){

		if (mirando && tiempo < Time.time) {
			Application.Quit ();

		}
	}



	public void activador(){

		Debug.Log ("hago algo");
	
		if(anim.GetBool ("mostrar") == false){
			anim.SetBool("mostrar", true);
			
		}else{
			
			anim.SetBool("mostrar",false);
		}
	}



}
