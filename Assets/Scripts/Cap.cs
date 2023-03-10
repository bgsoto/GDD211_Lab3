using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cap : MonoBehaviour
{
    public int sCount;

     void Start()
    {

       // sCount = 0;

    }
    void OnCollisionEnter(Collision collsion)
    {
        if (collsion.gameObject.CompareTag("Cube"))
        {

            sCount = sCount + 1;

        }

        Debug.Log("hit");
    }
}
