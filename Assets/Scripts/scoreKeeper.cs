using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class scoreKeeper : MonoBehaviour
{
    
     public TMP_Text currentscore;
     Cap s;

     void Start()
    {


        s = GameObject.Find("cubecollector").GetComponent<Cap>();

    }

    public void Update()
    {

        int p = s.sCount;
        currentscore.text = p.ToString("0");

    }

}
