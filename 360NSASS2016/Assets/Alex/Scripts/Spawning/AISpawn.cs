using UnityEngine;
using System.Collections;

public class AISpawn : MonoBehaviour {

	private GameObject objSpawn;
	private int SpawnerID;
	
	void Start () 
	{
		objSpawn = (GameObject)GameObject.FindWithTag ("Spawner");
	}
	
	void removeMe () 
	{
		objSpawn.BroadcastMessage ("kilEnemy", SpawnerID);
		//Destroy (gameObject);
	}
	void setName(int sName)
	{
		SpawnerID = sName;
	}
}
