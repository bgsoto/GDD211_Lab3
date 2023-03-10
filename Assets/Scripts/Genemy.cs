using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.Windows.Speech;

public class Genemy : enemy
{


    public scoreKeeper scoreKeeper;
    // Start is called before the first frame update
    void Start()
    {
        time = Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(speed, 0f, 0f);
    }

    void OnCollisionEnter(Collision collision)
        {
         if (collision.gameObject.CompareTag("GreenCubeCatcher")) 
        
            {
           // sCount = sCount + 1;
            cod();
            
            }
       }

}
