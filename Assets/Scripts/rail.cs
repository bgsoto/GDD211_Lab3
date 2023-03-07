using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rail : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private float time;

    // Start is called before the first frame update
    void Start()
    {
        time = Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(speed,0f,0f);
    }
}
