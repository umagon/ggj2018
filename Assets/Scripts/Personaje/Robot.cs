
using UnityEngine;
using System.Linq;

public class Robot : MonoBehaviour {

	// Use this for initialization
	public GameObject movimiento;
	private int indice = 0;
    public System.Collections.Generic.List<string> movs ;
	private string[] señ;

	private float timer = 1.0f;
	private float timerReset= 1.0f;

	private bool arriba= false;
	private bool derecha = false;

	private bool izquierda = false;

	private bool abajo = false;

	private int cantidadSeñales= 0;

	public bool enMovimiento= true;
	void Start () {
		movs = movimiento.GetComponent<Movimientos>().señales;
		cantidadSeñales = movs.Count;
		Debug.Log(cantidadSeñales);
		señal(indice);
	
		/*foreach(string movimiento in movs)
		{
			if(movimiento.Equals("up"))
			{	

				//transform.Translate ( Vector2.up  *Time.deltaTime );
			}
			
		}*/
		
	}
	
	// Update is called once per frame
	void Update () {

	if(enMovimiento)
	{
		if(arriba)
		{
			transform.Translate ( Vector2.up  *Time.deltaTime );
			timer -= Time.deltaTime;
			if(timer < 0)
			{
				arriba = false;
				timer = timerReset;
				señal(indice);
			}
			
		}

		if(derecha)
		{
			transform.Translate ( Vector2.right  *Time.deltaTime );
			timer -= Time.deltaTime;
			if(timer < 0)
			{
				derecha = false;
				timer = timerReset;
				señal(indice);
			}
		}
		if(izquierda)
		{
			transform.Translate ( Vector2.left  *Time.deltaTime );
			timer -= Time.deltaTime;
			if(timer < 0)
			{
				izquierda = false;
				timer = timerReset;
				señal(indice);
			}
		}

		if(abajo)
		{
			transform.Translate ( Vector2.down  *Time.deltaTime );
			timer -= Time.deltaTime;
			if(timer < 0)
			{
				abajo = false;
				timer = timerReset;
				señal(indice);
			}
		}
	}
	if(enMovimiento == false)
	{
		abajo= false;
		arriba = false;
		derecha = false;
		izquierda = false;
	}	

		
	}

	public void señal(int numero)
	{

		if(movs.ElementAt(numero) == "up")
		{
			arriba= true;
			indice++;
		}
		if(movs.ElementAt(numero) == "down")
		{
			abajo= true;
			indice++;
		}

		if(movs.ElementAt(numero) == "right")
		{
			derecha= true;
			indice++;
			
		}
		if(movs.ElementAt(numero) == "left")
		{
			izquierda= true;
			indice++;
		}
		if(movs.ElementAt(numero) == "space")
		{
			//derecha= true;
			indice++;
		}
	
	}

	/// <summary>
	/// Sent when another object enters a trigger collider attached to this
	/// object (2D physics only).
	/// </summary>
	/// <param name="other">The other Collider2D involved in this collision.</param>
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag =="fuego")
		{
			//aca choca con fuego
		}

		if(other.tag =="chispa")
		{

			Debug.Log("toca en chispaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
			enMovimiento = false;
			indice = 0;
			
			movs = null;
			movimiento.GetComponent<Movimientos>().sacarFlechas();
			movimiento.GetComponent<Movimientos>().activado = true;
			movimiento.GetComponent<Movimientos>().indice = 0;
			Destroy(other.gameObject);
		}

		if(other.tag=="boton")
		{
			other.gameObject.GetComponent<AbrirPuerta>().abrirPuertas();
		}
		if(other.tag=="pasarEscena")
		{
			Debug.Log("paso al nivel 2");
		}
		if(other.tag=="pared")
		{
			Destroy(this.gameObject);
		}
	}
}
