using UnityEngine;
using System.Collections;

public class CameraFollowScript : MonoBehaviour 
{
	public Transform player;
	void Update () 
	{
		transform.position = new Vector3 (player.position.x + 6, player.position.y + 2, -10);
	}
}
