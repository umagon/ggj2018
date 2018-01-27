using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientos : MonoBehaviour {

	public bool activado = true;
	public System.Collections.Generic.List<string> señales = new List<string>();
	private int indice;
	// Use this for initialization
	void Start () {
		indice = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//si esta activado todavia se puede mandar mas señales
		if(activado)
		{
			if( Input.GetKeyDown( KeyCode.Space ) )
			{
				señales.Add("space");
				Debug.Log( "tocamos flecha espacio." );
			}
			if( Input.GetKeyDown( KeyCode.RightArrow ) )
			{
				señales.Add("right");
				Debug.Log( "tocamos flecha derecha." );			 
			}

			if( Input.GetKeyDown( KeyCode.LeftArrow ) )
			{
				señales.Add("left");
				Debug.Log( "tocamos flecha izquierda." );						
			}
			
			if( Input.GetKeyDown( KeyCode.UpArrow ) )
			{
				señales.Add("up");
				Debug.Log( "tocamos flecha arriba." );		
			}

			if( Input.GetKeyDown( KeyCode.DownArrow ) )
			{
				señales.Add("down");
				Debug.Log( "tocamos flecha abajo." );
							
			}
		}
		
           
	}
}
