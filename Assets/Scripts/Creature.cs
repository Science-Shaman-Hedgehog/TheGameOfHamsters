using UnityEngine;
using System.Collections;
[RequireComponent (typeof (Rigidbody2D))]
public class Creature : HObject 
{

	public Rigidbody2D body;
	void Start()
	{
		body = GetComponent<Rigidbody2D> ();
	}
	
}