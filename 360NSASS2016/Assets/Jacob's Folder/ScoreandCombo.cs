using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreandCombo : MonoBehaviour
{
    [SerializeField]
    Text ScoreText;

    [SerializeField]
    float CurrentScore;

    [SerializeField]
    float Score;

	void Start ()
    {
        ScoreText.text = "Score: " + Score;

        Score = 0;

        CurrentScore = Score;
	}
	
	void FixedUpdate ()
    {
        ScoreText.text = "Score: " + CurrentScore;
	}

    void OnTriggerEnter2D(Collider2D other)
    {

        Debug.Log("The Trigger has happened");

        if (other.tag == "Player")
        {
            CurrentScore = CurrentScore + 10f;
        }
    }
}
