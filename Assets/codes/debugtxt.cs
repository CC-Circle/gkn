using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debugtxt : MonoBehaviour
{
    public static bool dtxt;
    Vector3 ookisa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dtxt){
            ookisa = this.transform.position; // ローカル変数に格納
            ookisa.x =  0.0f;
            Debug.Log(ookisa);
            this.transform.position = ookisa;
        }
    }
}
