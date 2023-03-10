using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class collect : MonoBehaviour
{

    public GameObject block ;
    public GameObject block2;
    //public int sCount;

    void Update()
    {
        

        if (Input.GetKey(KeyCode.E))
        {
            block.SetActive(true);
            

            
        }

        else if (Input.GetKey(KeyCode.Q))
        {
            block2.SetActive(true);
        }

        else
        {
            block.SetActive(false); 
            block2.SetActive(false);
        }

        //OnCollisionEnter(Collision collsion){ 
        
        

    }
    


}
