using UnityEngine;
using System.Collections;

public class AddingScore : MonoBehaviour
{

    public Score addingScore;


    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Much Trigger such Wow");

        if (other.tag == "Player")
        {

            if (this.gameObject.tag == "Basic")
            {
                Debug.Log("Trigger Level Basic");

                Destroy(this.gameObject);

                addingScore.currentScore = addingScore.currentScore + 10f;

                addingScore.currentCombo = addingScore.currentCombo + 1f;
            }
            if (this.gameObject.tag == "Advanced")
            {
                Debug.Log("Trigger Level Advanced");

                Destroy(this.gameObject);

                addingScore.currentScore = addingScore.currentScore + 50f;

                addingScore.currentCombo = addingScore.currentCombo + 1f;
            }
        }
    }

}
