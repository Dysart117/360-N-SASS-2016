using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    Rigidbody2D kMovement;
    public float kSpeed;

    // Use this for initialization
    void Start ()
    {
        kMovement = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetKey("w"))
        {
            kMovement.AddForce(new Vector2(0, kSpeed));
            
        }
        if (Input.GetKey("s"))
        {
            kMovement.AddForce(new Vector2(0, -kSpeed));
            
        }
        if (Input.GetKey("d"))
        {
            kMovement.AddForce(new Vector2(kSpeed, 0));
            
        }
        if (Input.GetKey("a"))
        {
            kMovement.AddForce(new Vector2(-kSpeed, 0));
            
        }
        if (kMovement.velocity.y >= kSpeed)
        {
            kMovement.velocity = new Vector2(kMovement.velocity.x, kSpeed);
        }
        if (kMovement.velocity.y <= -kSpeed)
        {
            kMovement.velocity = new Vector2(kMovement.velocity.x, -kSpeed);
        }
        if (kMovement.velocity.x >= kSpeed)
        {
            kMovement.velocity = new Vector2(kSpeed, kMovement.velocity.y);
        }
        if (kMovement.velocity.x <= -kSpeed)
        {
            kMovement.velocity = new Vector2(-kSpeed, kMovement.velocity.y);
        }

        gameObject.transform.Rotate(new Vector3(0,0,1));
    }
}
