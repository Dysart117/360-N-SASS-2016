using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NewObjectpoolerScript : MonoBehaviour 	
{
	public static NewObjectpoolerScript current;
	public GameObject pooledObject;
	public int pooledAmount = 50;
	public bool willGrow = false;		
	List<GameObject> pooledObjects;
	

	void Awake()	
	{	
		current = this;	
	}

	void Start () 	
	{
		pooledObjects = new List<GameObject> ();
		for (int i = 0; i < pooledAmount; i++) 	
		{	
			GameObject obj = (GameObject)Instantiate(pooledObject);	
			obj.SetActive(false);
			pooledObjects.Add(obj);
		}
	}

	public GameObject GetPooledObject()	
	{	
		for (int i = 0; i < pooledObjects.Count; i ++) 		
		{	
			if(!pooledObjects[i].activeInHierarchy)		
			{		
				return pooledObjects[i];
			}
		}
		if (willGrow) 	
		{
			GameObject obj = (GameObject)Instantiate(pooledObject);	
			pooledObjects.Add(obj);	
			return obj;	
		}	
		return null;
		
	}
	
}