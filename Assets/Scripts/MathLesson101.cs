using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MathLesson101 : MonoBehaviour
{
    int a = 5;
    int x = 7;
    int y = 9;

    void QuickMath()
    {
        if (a < x)
        {
            if (a + y < x)
            {
                Debug.Log("x is the biggest number");
            }


            else
                Debug.Log("x is not the biggest number");
        }
        else
        {
            Debug.Log(a %= y);
        }  
    }
    // Start is called before the first frame update
    void Start()
    {
        QuickMath();
    }
}
