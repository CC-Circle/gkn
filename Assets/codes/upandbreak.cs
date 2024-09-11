using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upandbreak : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 iti;
    int c;
    void Start()
    {
        c=0;
    }

    // Update is called once per frame
    void Update()
    {
        iti=transform.position;
        iti.y+=0.04f;
        transform.position=iti;
        c++;
        if(c>50){
            Destroy(this.gameObject);
        }
    }
}
