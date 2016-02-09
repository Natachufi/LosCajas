using UnityEngine;
using System.Collections;

public class tiempo : MonoBehaviour {

	private gestiontiempo gt;
	public float segundosextra;
	public bool unavez = false;

	//todas las banderillas deberan tener dos collider  que sobresalgan en los extremos con este script incorporado

	void Start () {
		gt = GameObject.Find ("Text").GetComponent<gestiontiempo>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider objeto){ 
		
		if (objeto.tag == "Player" && !unavez){
			Debug.Log ("personaje dentro " + segundosextra);
			gt.tiempoextra(segundosextra);
			unavez = true;
		}
		
	}
	void OnTriggerExit(Collider objeto){
		if (objeto.tag == "Player"){
			unavez = false;
		}
	}

}
