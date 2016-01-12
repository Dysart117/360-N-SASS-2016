using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public int health = 100;
    public Text healthText;

    void Start()
    {
        health = 100;
        SetHealthText();
    }

    /* void OnTriggerEnter2D(Collider2D player)
     {
         if (player.isTrigger)
         {
             
         }
         if (health == 0)
         {
             SetHealthText();
             Debug.Log("DEAD");
         }
     }*/
    public void SetHealthText()
    {
        healthText.text = "Health: " + health.ToString();
    }
}
