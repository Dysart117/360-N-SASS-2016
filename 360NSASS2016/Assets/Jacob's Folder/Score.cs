using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    [SerializeField]
    PlayerMovement speed;

    [SerializeField]
    PlayerHealth healthStuff;

    [SerializeField]
    AddingScore ComboStuff;

    [SerializeField]
    Text scoreText;

    [SerializeField]
    Text comboText;

    [SerializeField]
    float Combo;

    [SerializeField]
    float score;

    public float currentScore = 0f;

    public float currentCombo = 0f;

	// Use this for initialization
	void Start ()
    {
        scoreText.text = "Score: " + score;

        comboText.text = "Combo: " + Combo;
	}
	
	
	void FixedUpdate ()
    {
        scoreText.text = "Score: " + currentScore;

        comboText.text = "Combo: " + currentCombo;

        if (currentCombo == 5f)
        {
            speed.kSpeed= 10f;
        }
        if (currentCombo == 10f)
        {
            healthStuff.health = healthStuff.health + 10;

            healthStuff.SetHealthText();

            if (healthStuff.health == 100)
            {
                ComboStuff.H100.SetActive(true);
            }
            if (healthStuff.health == 90)
            {
                ComboStuff.H90.SetActive(true);
            }
            if (healthStuff.health == 80)
            {
                ComboStuff.H80.SetActive(true);
            }
            if (healthStuff.health == 70)
            {
                ComboStuff.H70.SetActive(true);
            }
            if (healthStuff.health == 60)
            {
                ComboStuff.H60.SetActive(true);
            }
            if (healthStuff.health == 50)
            {
                ComboStuff.H50.SetActive(true);
            }
            if (healthStuff.health == 40)
            {
                ComboStuff.H40.SetActive(true);
            }
            if (healthStuff.health == 30)
            {
                ComboStuff.H30.SetActive(true);
            }
            if (healthStuff.health == 20)
            {
                ComboStuff.H20.SetActive(true);
            }
            if (healthStuff.health == 10)
            {
                ComboStuff.H10.SetActive(true);
            }
            if (healthStuff.health > 100)
            {
                healthStuff.health = 100;
            }
        }
    }
}
