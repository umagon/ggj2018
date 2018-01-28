using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Movimientos : MonoBehaviour {

	public GameObject robot;
	public bool activado = true;
	public System.Collections.Generic.List<string> señales = new System.Collections.Generic.List<string>();
	private int indice;
	// Use this for initialization

	public System.Collections.Generic.List<GameObject> mensajes = new System.Collections.Generic.List<GameObject>();

	public Sprite flechaDer;
	public Sprite flechaIzq;
	public Sprite flechaAbajo;
	public Sprite flechaArriba;
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
				transmitir();
			}
			if( Input.GetKeyDown( KeyCode.RightArrow ) )
			{
				señales.Add("right");
				Debug.Log( "tocamos flecha derecha." );	
				mensajes.ElementAt(indice).SetActive(true);
				mensajes.ElementAt(indice).GetComponent<Image>().sprite = flechaDer;
				indice++;		 
				
			}

			if( Input.GetKeyDown( KeyCode.LeftArrow ) )
			{
				señales.Add("left");
				Debug.Log( "tocamos flecha izquierda." );	
				mensajes.ElementAt(indice).SetActive(true);
				mensajes.ElementAt(indice).GetComponent<Image>().sprite = flechaIzq;
				indice++;					
			}
			
			if( Input.GetKeyDown( KeyCode.UpArrow ) )
			{
				señales.Add("up");
				Debug.Log( "tocamos flecha arriba." );	
				mensajes.ElementAt(indice).SetActive(true);
				mensajes.ElementAt(indice).GetComponent<Image>().sprite = flechaArriba;
				indice++;	
			}

			if( Input.GetKeyDown( KeyCode.DownArrow ) )
			{
				señales.Add("down");
				Debug.Log( "tocamos flecha abajo." );
				mensajes.ElementAt(indice).SetActive(true);
				mensajes.ElementAt(indice).GetComponent<Image>().sprite = flechaAbajo;
				indice++;
							
			}
		}
		
           
	}

	public void transmitir()
	{
		robot.GetComponent<Robot>().enabled= true;
	}

	
}
