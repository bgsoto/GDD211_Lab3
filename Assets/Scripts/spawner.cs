using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] GameObject[] cubes;
    [SerializeField] Transform location;
    public float count;
    public Rigidbody rb;
    public Rigidbody gb;
    //int n = Random.Range(0, cubes.Length);
    

    // Start is called before the first frame update
    void Start()
    {
        //rb.WakeUp();
    }

    // Update is called once per frame
    void Update()
    {
       // tick = Random.Range(0, cubes.Length);
        rb.WakeUp();
        if (count >= 2f)
       
        {
            int n = Random.Range(0, cubes.Length);
            Instantiate(cubes[n], location);
            count = 0;
            Debug.Log(count);

        }

        count += Time.deltaTime ;

        //Debug.Log(count);
        
    }
}
