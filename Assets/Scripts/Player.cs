using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Player : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject coolTextBox;

    int currentScore = 0;

    Door currentDoor;

    Collectible currentCollectible;

    public void IncreaseScore(int scoreToAdd)
    {
        //coolTextBox.SetActive(true);
        currentScore += scoreToAdd;
        scoreText.text = "Score: " + currentScore.ToString();
    }

    public void UpdateDoor(Door newDoor)
    {
        currentDoor = newDoor;
    }

    public void UpdateCollectible(Collectible newCollectible)
    {
        currentCollectible = newCollectible;
    }
    void OnInteract()
    {
        //Null check
        if (currentDoor != null)
        {
            currentDoor.OpenDoor();
            currentDoor = null;
        }

        //Null check for currentCollectible
        if(currentCollectible != null)
        {
            IncreaseScore(currentCollectible.myScore);
            currentCollectible.Collected();
        }
    }
}
