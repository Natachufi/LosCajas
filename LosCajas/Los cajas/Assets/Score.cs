using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	public Animator score;
	public Animator banderolas;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	


	
	}

	void OnTriggerEnter (Collider objeto) {
		    
			Debug.Log ("entra");

		if (objeto.transform.tag == "Player") {


			score.SetTrigger ("entra");
			banderolas.SetTrigger ("entran");

		}
	}


}
