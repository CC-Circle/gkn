using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;

//using JetBrains.Rider.Unity.Editor;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class bpm100 : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 ookisa;
    Vector3 timerise;
    public static bool taiminngu;
    public static int haato;
    bool ok;
    float last;
    bool riseok;
    public static bool sinmaok;
    float sinmadametime;
    [SerializeField] private int matikazu;
    public static bool sinmaokok;

    bool lastok;
    public GameObject sindenzu;
    public GameObject aka; 
    bool underbarok;
    void Start()
    {
        Time.timeScale = 5 / 3f;
        haato = 0;
        ok = true;
        ookisa = transform.localScale; // ローカル変数に格納
        ookisa.x = 0.2f;
        ookisa.y = 0.2f;
        transform.localScale = ookisa;
        last = 0.0f;
        riseok = false;
        sinmaok = true;
        sinmaokok=true;
        lastok=false;
        underbarok=true;
    }

    void sp(){
        if(lastok==true){
            Instantiate(sindenzu);
            underbarok=false;
        }else{
            Instantiate(aka);
            underbarok=false;
        }
    }

    void sinma()
    {
        if (taiminngu)
        {
            last = Time.realtimeSinceStartup;
            haato += 20;
            ookisa = transform.localScale; // ローカル変数に格納
            ookisa.x += 0.1f;
            ookisa.y += 0.1f;
            Debug.Log(ookisa);
            transform.localScale = ookisa;
            riseok = true;
            lastok=true;

            if (haato >= 100)
            {
                haato = 0;
                points.cp = true;
                points.point += 1;
                ookisa = transform.localScale; // ローカル変数に格納
                ookisa.x = 0.25f;
                ookisa.y = 0.25f;
                transform.localScale = ookisa;

            }
            taiminngu = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(SerialReceive.data);
        if(0f<=Time.time*100%100&&Time.time*100%100<=6f&&underbarok){
            sp();
        }
        if (Input.GetKey(KeyCode.Return) && sinmaok || sinmaok && SerialReceive.data==1)//retirnキーが押されれるor心マされた時sinmaokの時
        {
            sinma();
        }
        //Debug.Log(Time.time);
        if (Time.time * 100 % 100 > 97.0f || Time.time * 100 % 100 < 3.0f)
        {
            if (ok)
            {
                ookisa = transform.localScale; // ローカル変数に格納
                ookisa.x += 0.05f;
                ookisa.y += 0.05f;
                transform.localScale = ookisa;

                taiminngu = true;
                ok = false;
                //Debug.Log("%100=0");
            }


        }
        if (Time.time * 100 % 100 > 7.0f && Time.time * 100 % 100 < 13.0f)
        {
            if (ok == false)
            {
                ookisa = transform.localScale; // ローカル変数に格納
                ookisa.x -= 0.05f;
                ookisa.y -= 0.05f;
                transform.localScale = ookisa;
                taiminngu = false;
                ok = true;
                underbarok=true;

            }
            lastok=false;
            //Debug.Log("%100=20");
        }
        if (Time.realtimeSinceStartup - last >= matikazu && riseok)
        {
            timerise = transform.localScale; // ローカル変数に格納
            timerise.x = 0.2f;
            timerise.y = 0.2f;
            transform.localScale = timerise;
            haato=0;
            riseok = false;
        }
        if (sinmaok != true&&sinmaokok)
        {
            sinmaokok=false;
            sinmadametime = Time.realtimeSinceStartup;
        }
        if (Time.realtimeSinceStartup - sinmadametime >= matikazu && sinmaok != true)
        {
            sinmaok = true;
            sinmaokok=true;

        }
    }
}
