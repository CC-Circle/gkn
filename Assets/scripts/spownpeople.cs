using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spownpeople : MonoBehaviour
{
    public GameObject pepole;
    int pn;
    float px,py;
    // Start is called before the first frame update
    void Start()
    {
        pn=0;
    }

    // Update is called once per frame
    void Update()
    {
        if(points.point>pn){
            pn++;
            px=Random.Range(-100,100);
            py=Random.Range(-500,500);
            px=10000.0f+px/10f;
            Debug.Log(py);
            py=py/100f;
            Debug.Log(py);
            Instantiate(pepole, new Vector3( px, py, 1.0f), Quaternion.identity);
        }
    }
}
