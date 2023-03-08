using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public  class enemy : MonoBehaviour
{

    public float speed;
    public float time;


    public void cod()
    {

       Destroy(gameObject);
        Debug.Log("hit");

    }

    // viirual allows override 
}
