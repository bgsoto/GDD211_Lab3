using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pLoc : MonoBehaviour
{
    [SerializeField] private Transform loc;
    [SerializeField] private float place;
    // Start is called before the first frame update
    void Start()
    {
        loc.position = new Vector3(-4.29f, 10.58f, -10.98f);
    }

    // Update is called once per frame
    void Update()
    {
        loc.position = new Vector3 (-4.29f,10.58f,-10.98f);
    }
}
