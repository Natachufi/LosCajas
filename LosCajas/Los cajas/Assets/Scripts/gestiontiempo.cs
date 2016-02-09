using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gestiontiempo : MonoBehaviour {

	public float minutos;
	public float segundos;
	public float penalizacion;
	public Text contador;

	//añadir este script al texto del contador en la iu   


	void Start () {

		contador = GetComponent<Text>() as Text;
	}
	

	public void Update () {

		tiempo();  
	}


	void tiempo (){

		minutos = (Time.timeSinceLevelLoad / 60f);
		
		segundos = (Time.timeSinceLevelLoad % 60f)+penalizacion;

		contador.text = minutos.ToString("00") + ":" + segundos.ToString("00");
	
	}


	public void tiempoextra(float segundosextra){

		Debug.Log 	(segundosextra);
		penalizacion +=	segundosextra % 60f;
	
	}

}
