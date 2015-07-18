using UnityEngine;
using System.Collections;

public class LongJump : Interactable {

	public string actor="player"; 
	public float power=1.0f; // Jump power
    void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name == actor) // When player contact object
		{
			Vector3 movement = new Vector3 (1.0f, 2.0f, 0.0f); // Derection		
			col.transform.position += movement * power * Time.deltaTime; // Moving(но кривое)
	     	Debug.Log("LongJump");
		}
    }
}
