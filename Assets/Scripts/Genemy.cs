using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class Genemy : enemy
{
    
   

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
         if ( collision.gameObject.CompareTag("Cube")) 
        
            { 
            // cod();
            Debug.Log("1");
            }
       }

}
