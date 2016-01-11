using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    [SerializeField] float kBulletSpeed;
    //[SerializeField] GameObject kBulletSpawn;

    // Use this for initialization
    void OnEnable()
    {
        Debug.Log("Ples");
        //float gunAngle = 0;
        //gunAngle = kBulletSpawn.transform.rotation.eulerAngles.z;

        //Vector3 bulletSpeed = new Vector3(kBulletSpeed * Mathf.Cos(gunAngle * 180 / Mathf.PI), kBulletSpeed * Mathf.Sin(gunAngle * 180 / Mathf.PI), 0);

        //gameObject.GetComponent<Rigidbody>().velocity = bulletSpeed;

        gameObject.GetComponent<Rigidbody>().AddForce(transform.right * kBulletSpeed);

        Invoke("Shutdown", 3f);
    }

	void Shutdown()
	{
        gameObject.GetComponent<Rigidbody>().velocity = new Vector2 (0, 0);
		gameObject.SetActive (false);
	}
	
}
