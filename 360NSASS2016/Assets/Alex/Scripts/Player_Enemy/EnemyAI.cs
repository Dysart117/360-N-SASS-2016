using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
	 
		public Transform target;
	public float speed = 3f;
	
	
	     void Start () {

		gameObject.tag = "Enemy";//
	}
	
	void Update(){
		         
			transform.LookAt(target.position);
		transform.Rotate(new Vector3(0,-90,0),Space.Self);
		         
		if (Vector3.Distance(transform.position,target.position)>1f){
			transform.Translate(new Vector3(speed* Time.deltaTime,0,0) );
		}

	}
	
}
