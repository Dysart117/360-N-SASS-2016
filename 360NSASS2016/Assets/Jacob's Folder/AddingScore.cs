using UnityEngine;
using System.Collections;

public class AddingScore : MonoBehaviour
{

    public Score addingScore;

    public GameObject H10;

    public GameObject H20;

    public GameObject H30;

    public GameObject H40;

    public GameObject H50;

    public GameObject H60;

    public GameObject H70;

    public GameObject H80;

    public GameObject H90;

    public GameObject H100;

    public PlayerHealth healthScript;


    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Much Trigger such Wow");

        if (other.tag == "Bullet")
        {

            if (this.gameObject.tag == "Baddy")
            {
                Debug.Log("Trigger Level Basic");

                Destroy(this.gameObject);

                addingScore.currentScore = addingScore.currentScore + 10f;

                addingScore.currentCombo = addingScore.currentCombo + 1f;
            }
            if (this.gameObject.tag == "AdvancedBaddy")
            {
                Debug.Log("Trigger Level Advanced");

                Destroy(this.gameObject);

                addingScore.currentScore = addingScore.currentScore + 50f;

                addingScore.currentCombo = addingScore.currentCombo + 1f;
            }
        }

        if(other.tag == "Player")
        {
            if (this.gameObject.tag == "Baddy" || this.gameObject.tag == "AdvancedBaddy")
            {
                addingScore.currentCombo = 0;

                healthScript.health = healthScript.health - 10;
                healthScript.SetHealthText();

                if (healthScript.health == 90)
                {
                    H100.SetActive(false);
                }
                if (healthScript.health == 80)
                {
                    H90.SetActive(false);
                }
                if (healthScript.health == 70)
                {
                    H80.SetActive(false);
                }
                if (healthScript.health == 60)
                {
                    H70.SetActive(false);
                }
                if (healthScript.health == 50)
                {
                    H60.SetActive(false);
                }
                if (healthScript.health == 40)
                {
                    H50.SetActive(false);
                }
                if (healthScript.health == 30)
                {
                    H40.SetActive(false);
                }
                if (healthScript.health == 20)
                {
                    H30.SetActive(false);
                }
                if (healthScript.health == 10)
                {
                    H20.SetActive(false);
                }
                if (healthScript.health == 0)
                {
                    H10.SetActive(false);
                    Debug.Break();
                }
            }

            }
        }
    }


