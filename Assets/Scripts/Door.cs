using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{
    bool opened = false;

    bool locked = false;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player" && !opened)
        {
            OpenDoor();

            other.gameObject.GetComponent<Player>().UpdateDoor(this);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Player>().UpdateDoor(null);
        }
    }

    public override void Interact(Player thePlayer)
    {
        base.Interact(thePlayer);
        OpenDoor();
    }

    public void OpenDoor()
    {
        if (!locked)
        {
            //Store the object's rotation
            Vector3 newRotation = transform.eulerAngles;
            //Modify the new variable
            newRotation.y += 90f;
            //Reassign the valure to the object's rotation
            transform.eulerAngles = newRotation;

            opened = true;
        }
    }

    public void SetLock(bool lockStatus)
    {
        locked = lockStatus;
    }
}
