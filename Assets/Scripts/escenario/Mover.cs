using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	public bool arriba ;
	public bool abajo;
	private float timer = 1.0f;

	public bool activado = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(activado)
		{
				if(arriba)
					{
						transform.Translate ( Vector2.up  *Time.deltaTime );
						timer -= Time.deltaTime;
						if(timer < 0)
						{
							arriba = false;
							
						}
					}
				if(abajo)
					{
						transform.Translate ( Vector2.down  *Time.deltaTime );
						timer -= Time.deltaTime;
						if(timer < 0)
						{
							abajo = false;
						
						}
					}
		}
	
	}
}
