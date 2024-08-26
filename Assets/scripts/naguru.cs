using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class naguru : MonoBehaviour
{
    public static int panti; 
    // Start is called before the first frame update
    void Start()
    {
        panti=0;
        
    }

    // Update is called once per fram

    void hit(){
        panti=1;
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            hit();
        }
    }
}
