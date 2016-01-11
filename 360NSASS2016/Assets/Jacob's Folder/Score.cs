using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    [SerializeField]
    SimpleMovement speed;

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
            speed.Speed = 10f;
        }
    }
}
