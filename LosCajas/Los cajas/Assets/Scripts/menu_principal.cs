using UnityEngine;
using System.Collections;

public class Interactivo : MonoBehaviour {
	public Material mat_activo;
	Material mat_inactivo;
	
	// Use this for initialization
	void Start () {
		mat_inactivo = GetComponent<Renderer> ().material;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void activar(){
		GetComponent<Renderer>().material = mat_activo;
	}
	
	public void desactivar(){
		GetComponent<Renderer>().material = mat_inactivo;
	}
	
	public void minimizar(){
		transform.localScale = transform.localScale / 2;
	}
}
