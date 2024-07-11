using System.Collections;
using System.Collections.Generic;
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
            transform.localScale = ookisa;
            riseok = true;

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
        Debug.Log(SerialReceive.data);
        
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
            }
            //Debug.Log("%100=20");
        }
        if (Time.realtimeSinceStartup - last >= 10 && riseok)
        {
            timerise = transform.localScale; // ローカル変数に格納
            timerise.x = 0.2f;
            timerise.y = 0.2f;
            transform.localScale = timerise;
            riseok = false;
        }
        if (sinmaok != true)
        {

            sinmadametime = Time.realtimeSinceStartup;
        }
        if (Time.realtimeSinceStartup - sinmadametime >= 10 && sinmaok != true)
        {
            sinmaok = true;

        }
    }
}
