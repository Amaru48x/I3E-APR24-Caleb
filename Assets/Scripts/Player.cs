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

    public void UpdateCollectible(Interactable newInteractable)
    {
        currentCollectible = newCollectible;
    }
    void OnInteract()
    {
        //Null check
        if (currentDoor != null)
        {
            //Interact with the object
            currentInteractable.Interact(this);
        }
    }
}
