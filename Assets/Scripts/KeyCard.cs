using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCard : MonoBehaviour
{
    // Start is called before the first frame update
    public Door linkedDoor;

    private void Start()
    {
        if (linkedDoor != null)
        {
            linkedDoor.SetLock(true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //Tell the door to unlock itself.
            linkedDoor.SetLock(false);
            Destroy(gameObject);
        }
    }
}
