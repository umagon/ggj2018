using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverAutomatico : MonoBehaviour {

	public bool derecha ;
	private float timer = 1.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	if(derecha == false)
	{
		if(timer > 0)
			{
				transform.Translate ( Vector2.down  *Time.deltaTime );
				timer -= Time.deltaTime;				
			}
	}		
	if(derecha == true)
	{
		if(timer > 0)
			{
				transform.Translate ( Vector2.up  *Time.deltaTime );
				timer -= Time.deltaTime;				
			}
	}	
	
		
	}
}
