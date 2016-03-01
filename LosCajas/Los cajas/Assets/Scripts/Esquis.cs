using UnityEngine;
using System.Collections;

public class Esquis : MonoBehaviour
{
	private AudioSource sonido;
	public GameObject terreno;
	
	
	// Use this for initialization
	void Start()
	{
		
		sonido = GetComponent<AudioSource>();
		
	}
	void OnCollisionEnter (Collision objeto)
	{
		
		if (terreno)
			sonido.Play();
		if (sonido.mute)
			
			sonido.mute = false;
		else
			sonido.mute = true;
		
		
		
		
	}
	
	
	void OnCollisionExit(Collision objeto)
	{
		
		if (terreno)
			
			if (sonido.mute)
				
				sonido.mute = true;
		else
			sonido.mute = false;
		
		
		
	}
}