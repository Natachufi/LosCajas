using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gestiontiempo : MonoBehaviour {

	public float minutos;
	public float segundos;

	public Text contador;

    //public float segundos, minutos;

	// Use this for initialization
	void Start () {

		contador = GetComponent<Text>() as Text;	
	

	}
	

	// Update is called once per frame
	void Update () {

		minutos = (Time.timeSinceLevelLoad / 60f);

		segundos = (Time.timeSinceLevelLoad % 60f);

		contador.text = minutos.ToString("00") + ":" + segundos.ToString("00");


	}
}
