using UnityEngine;
using System.Collections;

public class menupausa : MonoBehaviour {

	private Animator anim;

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if(anim.GetBool ("mostrar") == false){
				anim.SetBool("mostrar", true);

			}else{

				anim.SetBool("mostrar",false);
			}
		}
	}

	public void oculta_menu(){
		Time.timeScale = 1f;
		anim.SetBool ("mostrar", false);
	}

	public void salir(){
		Application.Quit ();
	}


}
