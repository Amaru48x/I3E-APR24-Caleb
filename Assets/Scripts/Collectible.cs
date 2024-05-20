using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int myScore = 5;
    bool fullInventory = false;
    string Coins = "many";
    bool collectedCoins = false;
    string colour = "yellow";

    public void Collected()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something entered my area");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Something left my area");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Something is still in my area");
    }


    private void OnCollisionEnter(Collision collision)
    {
        //Check if whatever collided with is the Player
        if (collision.gameObject.tag == "Player")
        {
            //Tell the player to increase its score
            //collision.gameObject.GetComponent<Player>().IncreaseScore(myScore);
            //Print message with my GameObject's name
            //Debug.Log("something collided with " + gameObject.name);
            collision.gameObject.GetComponent<Player>().UpdateCollectible(this);
            //Destroy(gameObject);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().UpdateCollectible(null);
        }
        //Debug.Log("something has stopped colliding");
    }

    private void OnCollisionStay(Collision collision)
    {
        //Debug.Log("something is still colliding");
    }
    void rotatingCoin()
    {

    }
    void hiddenCoin()
    {

    }
    void obtainCoin()
    {
        if (collectedCoins)
        {

        }
        else
        {

        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
