using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] GameObject cube;
    [SerializeField] Transform location;
    public float count;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //rb.WakeUp();
    }

    // Update is called once per frame
    void Update()
    {
        rb.WakeUp();
        if (count >= 2f)
       
        {

            Instantiate(cube, location);
            count = 0;
            Debug.Log(count);
        }

        count += Time.deltaTime ;

        //Debug.Log(count);
        
    }
}
