using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour

{
    public void RemovePlayer(Player thePlayer)
    {
        thePlayer.UpdateInteractable(this);
    }

    public void RemovePlayerInteractable(Player thePlayer)
    {
        thePlayer.UpdateInteractable(null);
    }

    public virtual void Interact()
    {
        Debug.Log(gameObject.name + "was interacted");
    }
}

