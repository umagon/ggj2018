using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuerta : MonoBehaviour {

	public GameObject puertaU;
	public GameObject puertaD;
	public Sprite presionado;
	public bool unaPuerta;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void abrirPuertas()
	{
		if(unaPuerta)
		{
			puertaU.GetComponent<Mover>().activado= true;
			puertaU.GetComponent<Mover>().arriba = true;
			this.GetComponent<SpriteRenderer>().sprite = presionado;
		}
		else
		{
			puertaD.GetComponent<Mover>().activado= true;
			puertaD.GetComponent<Mover>().abajo = true;

			puertaU.GetComponent<Mover>().activado= true;
			puertaU.GetComponent<Mover>().arriba = true;
			Debug.Log("abre puerta");
		}
		
	}
}
