using UnityEngine;
using System.Collections;

public class principal_creditos : MonoBehaviour {

	Animator anim;
	public float tiempo_mirada = 3f;
	float tiempo = 0;
	bool mirando = false;
	bool activado = false;
	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(mirando && tiempo < Time.time  ){
			anim.SetBool("activado",true);
		}

		
	}
	
	public void grande() { //cuando el boton se hace grande
		anim.SetBool("mirando",true);
		mirando = true;
		tiempo = Time.time + tiempo_mirada; 
		Debug.Log ( "grande");
		
	}
	public void pequeno(){ //cuando el boton vuelve a su tamaño original
		anim.SetBool("mirando", false);
		mirando = false;
		Debug.Log ( "pequeño");
		
	}

	public void sale_creditos(){ //cuando el boton vuelve a su tamaño original
		anim.SetBool("mirando", false);
		mirando = false;
		Debug.Log ( "pequeño");
		anim.SetBool("activado",false);
	}
}
