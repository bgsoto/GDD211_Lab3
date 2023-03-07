using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redenemy : enemy
{







    void Start()
    {
        time = Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(speed, 0f, 0f);
    }



}


