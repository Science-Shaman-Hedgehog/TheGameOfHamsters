﻿using UnityEngine;
using System.Collections;

public class Thorns : Interactable {

	public string actor="player"; 
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name == actor) // When player contact object
		{
			Destroy(col.gameObject);
			Debug.Log("Death");
		}
	}
}
