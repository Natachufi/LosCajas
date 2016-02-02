using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gestionpuntos : MonoBehaviour {

	//poner script a jugador

	public Text textopuntos; // vincular el texto que mostrara los puntos
	public int puntos = 0; 

	public void sumapuntos(int nuevospuntos){
	
		puntos = puntos + nuevospuntos;
		textopuntos.text = " " + puntos;
	
	}

}
