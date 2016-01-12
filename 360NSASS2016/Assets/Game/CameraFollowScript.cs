using UnityEngine;
using System.Collections;

public class CameraFollowScript : MonoBehaviour 
{
	public Transform player;
	void Update () 
	{
		transform.position = new Vector3 (player.position.x, player.position.y, -0.54f);
	}
}
