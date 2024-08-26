using System.Collections;
using System.Collections.Generic;
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
            ookisa.x -= 0.1f;
        transform.position = ookisa;
    }
}
