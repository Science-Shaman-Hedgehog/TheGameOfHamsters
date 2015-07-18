using UnityEngine;
using System.Collections;

public class Button_Destroy : Interactable {

	public string actor="player"; 
	public Object active;
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name == actor) // When player contact object
		{
			Destroy(active);
		}
	}
}
