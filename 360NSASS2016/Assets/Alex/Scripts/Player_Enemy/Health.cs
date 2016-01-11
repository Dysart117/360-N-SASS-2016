using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	
	public Collider2D player;
	public float health = 100;

	void OnTriggerEnter2D(Collider2D player)
	{
		if(player.isTrigger)
		{
			health = health - 10;
		}
		if (health == 0) 
		{
			Debug.Log ("DEAD");
		}
	}
}