using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Movimientos : MonoBehaviour {

	public int nivel;
	public GameObject robot;
	public bool activado = true;
	public System.Collections.Generic.List<string> señales = new System.Collections.Generic.List<string>();
	public int indice;
	// Use this for initialization

	public System.Collections.Generic.List<GameObject> mensajes = new System.Collections.Generic.List<GameObject>();

	public Sprite flechaDer;
	public Sprite flechaIzq;
	public Sprite flechaAbajo;
	public Sprite flechaArriba;
	private bool recarga = false;
	void Start () {
		indice = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//si esta activado todavia se puede mandar mas señales
		if(recarga){
			if( Input.GetKeyDown( KeyCode.Backspace ) )
			{
				Debug.Log("recargar");
				if(nivel == 1)
				{
					Application.LoadLevel("nivel1");
				}
				if(nivel == 2)
				{
					Application.LoadLevel("nivel2");
				}
				if(nivel == 3)
				{
					Application.LoadLevel("nivel3");
				}
			}
		}
		if(activado)
		{
			if( Input.GetKeyDown( KeyCode.Space ) )
			{
				transmitir();
			}
			if( Input.GetKeyDown( KeyCode.KeypadEnter ) )
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
		
		if(indice >= 20)
		{
			indice=19;	
		}

           
	}

	public void transmitir()
	{
		activado = false;
		recarga=true;
		if(robot.GetComponent<Robot>().enabled== true)
		{
			robot.GetComponent<Robot>().enMovimiento= true;
			robot.GetComponent<Robot>().movs = señales;
			robot.GetComponent<Robot>().señal(0);
		}
		else{
			robot.GetComponent<Robot>().enabled= true;
		}
	}

	public void sacarFlechas()
	{
		for(int i = 0 ; i <mensajes.Count;i++)
		{
			mensajes.ElementAt(i).SetActive(false);
			
		}
		señales = new System.Collections.Generic.List<string>();
	}

	
}
