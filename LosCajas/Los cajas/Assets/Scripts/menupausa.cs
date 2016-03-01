using UnityEngine;
using UnityEngine.UI;
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


	public void oculta_menu(){ //funcion que oculta el menu


        	Debug.Log ("reanudo"); 
			anim.SetBool ("mostrar", false);
			Time.timeScale = 1f;

		}



	public void salir() { //funcion que sale del juego

			Application.Quit ();

		}



	public void muestra_menu () { //funcion que muestra el menu
	
		if(anim.GetBool ("mostrar") == false){ //si el menu esta oculto
			anim.SetBool("mostrar", true); //el menu se vuelve visible
			Parartiempo();
			Debug.Log ("tiempo parado");
		}
	}

	public void parpadea (){ //funcion que hace resaltar los botones


		anim.SetBool ("mirando", true);
		mirando = true;
		
	}
	
	public void noparpadea(){ //funcion que hace que los botones dejen de resaltar

		anim.SetBool ("mirando", false);
		mirando = false;

	}
	void Parartiempo(){

		Debug.Log ("paro el tiempo");
		Time.timeScale = 0; //pausamos el juego
	}



}
