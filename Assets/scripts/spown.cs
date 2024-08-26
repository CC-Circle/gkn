using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spown : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lzon;
    public GameObject mzon; 
    public GameObject rzon;
    int n;
    public static int lspo,mspo,rspo;
    float lx,ly,mx,my,rx,ry;
        void Start()
    {
        lspo=1;
        mspo=1;
        rspo=1;   
    }

    // Update is called once per frame
    void Update()
    {
        //c=Random.Range(a,b);でcにaからbまでのランダムな数字を代入
        n=Random.Range(1,20000);
        if(n<=10||Input.GetKey(KeyCode.L)){
            lx=(Random.Range(0,150)-50.0f)/100.0f-7.0f;
            ly=Random.Range(0,200)/100.0f;
            Instantiate(lzon, new Vector3( lx, ly, 0.0f), Quaternion.identity);
        }else if(n<=20||Input.GetKey(KeyCode.U)){
            mx=(Random.Range(0,100)-50.0f)/100.0f;
            my=Random.Range(0,200)/100.0f;
            Instantiate(mzon, new Vector3( mx, my, 0.0f), Quaternion.identity);
        }else if(n<=30||Input.GetKey(KeyCode.R)){
            rx=(Random.Range(0,150)-50.0f)/100.0f+7.0f;
            ry=Random.Range(0,200)/100.0f;
            Instantiate(rzon, new Vector3( rx, ry, 0.0f), Quaternion.identity);
        }
    }
}
