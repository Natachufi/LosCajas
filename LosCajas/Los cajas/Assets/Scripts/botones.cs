using UnityEngine;
using System.Collections;

public class botones : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void salir (){
		Application.Quit ();
	}

	public void reanudar () {
		Application.LoadLevel ("pruebaluciana");
	}
}
