using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GunFire : MonoBehaviour {

	[SerializeField] float fireTime;
    float m_CoolDown = 0;
	public GameObject bullet;

//	public int pooledAmount = 40;
//	List<GameObject> bullets;

//	void Start()
//	{
//		bullets = new List<GameObject> ();
//		for(int i = 0; i < pooledAmount; i++)
//		{
//			GameObject obj = (GameObject)Instantiate (bullet);
//			obj.SetActive (false);
//			bullets.Add (obj);
//		}
//	}

	void Update()
	{
        if (Input.GetButton("Fire1"))
        {
            if (Time.time > m_CoolDown)
            {
                Fire();
                m_CoolDown = Time.time + fireTime;
            }
        }
	}
	
	void Fire()
	{

        //Instantiate(bullet, gameObject.transform.position, Quaternion.identity);
        //bullet.GetComponent<Rigidbody>().AddForce(Vector3.forward * 200000);

        GameObject obj = NewObjectpoolerScript.current.GetPooledObject ();

        if (obj == null)
        return;
        obj.transform.position = gameObject.transform.position;
        obj.transform.rotation = gameObject.transform.rotation;
        obj.SetActive (true);

    }
}
	

