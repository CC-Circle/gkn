using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class hidarimove : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 ookisa;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ookisa = transform.position; // ローカル変数に格納
        if(ookisa.x>=9900){
            ookisa.x -= 0.4f;
        }else {
            Destroy (this.gameObject);
        }
        if(ookisa.x<=10000.125&&9999.875<=ookisa.x){
            Debug.Log(Time.time);
        }
        transform.position = ookisa;
        
    }
}
