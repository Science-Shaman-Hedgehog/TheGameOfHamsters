using UnityEngine;
using System.Collections;

public class Player : Creature
{
	[RangeAttribute(250, 1000)]
	public float speed=250;
	[RangeAttribute(1, 10)]
	public float jump=1;
	void FixedUpdate()
	{
		body.AddForce (new Vector2(Input.GetAxis ("Horizontal") * speed * Time.deltaTime,0));
		if (Input.GetKeyDown (KeyCode.Space))
		{
			body.AddForce(Vector2.up*jump,ForceMode2D.Impulse);
		}
	}
}
