﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void jugar()
	{
		Application.LoadLevel("nivel1");
	}

	public void volverMenu()
	{
		Application.LoadLevel("menu");
	}
}
