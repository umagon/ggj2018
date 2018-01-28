using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {
	public float warmUp = 2;
	public GameObject efectoWarmUp;
	public GameObject efectoRayo;

	private float contador = 0;
	private GameObject objetivo;
	private GameObject efectoEnCurso;
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(objetivo != null){
			
			contador += Time.deltaTime;

			if(efectoEnCurso == null)
				efectoEnCurso = Instantiate(efectoWarmUp, gameObject.transform);

			Debug.Log(contador - warmUp);

			if(contador - warmUp >= 0.5){
				Disparar(objetivo);
				contador = 0;
			}
		} else {
			contador = 0;
			if(efectoEnCurso != null){
				Destroy(efectoEnCurso);
			}
		}
	}
	
	/// <summary>
	/// Sent each frame where another object is within a trigger collider
	/// attached to this object (2D physics only).
	/// </summary>
	/// <param name="other">The other Collider2D involved in this collision.</param>
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "Personaje"){
			objetivo = other.gameObject;
		}
	}
	
	void OnTriggerExit2D(Collider2D other)
	{
		Debug.Log("se fue");
		objetivo=null;
	}
	

	void Disparar(GameObject target){
		//Acá iría una animación
		GameObject rayo = Instantiate(efectoRayo);
		LineRenderer linea = rayo.GetComponent<LineRenderer>();
		linea.SetPosition(0, gameObject.transform.position);
		linea.SetPosition(1, target.transform.position);
		Destroy(rayo, 0.5f);
		Debug.Log("murió");
		Destroy(target);
	}
}
