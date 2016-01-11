using UnityEngine;
using System.Collections;

public class AddingScore : MonoBehaviour
{

    public Score addingScore;

    [SerializeField]
    GameObject H10;

    [SerializeField]
    GameObject H20;

    [SerializeField]
    GameObject H30;

    [SerializeField]
    GameObject H40;

    [SerializeField]
    GameObject H50;

    [SerializeField]
    GameObject H60;

    [SerializeField]
    GameObject H70;

    [SerializeField]
    GameObject H80;

    [SerializeField]
    GameObject H90;

    [SerializeField]
    GameObject H100;

    public Health healthScript;


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
            if (this.gameObject.tag == "BaddyMark2")
            {
                Debug.Log("Trigger Level Advanced");

                Destroy(this.gameObject);

                addingScore.currentScore = addingScore.currentScore + 50f;

                addingScore.currentCombo = addingScore.currentCombo + 1f;
            }
        }
        if(other.tag == "Player")
        {
            if (this.gameObject.tag == "Baddy")
            {

                Debug.Log("Take that;");

                if (addingScore.currentCombo == 0)
                {
                    addingScore.currentCombo = 0;
                }

                Debug.Log("Losing health");

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

                if (this.gameObject.tag == "BaddyMark2")
                {

                    Debug.Log("Take that;");

                    if (addingScore.currentCombo == 0)
                    {
                        addingScore.currentCombo = 0;
                    }

                    Debug.Log("Losing health");

                    healthScript.health = healthScript.health - 20;
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

}
