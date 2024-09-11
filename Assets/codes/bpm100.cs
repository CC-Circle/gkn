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

    int lastok;
    public GameObject sindenzu;
    public GameObject aka; 
    bool underbarok;
    public GameObject seikou;
    public GameObject sippai;
    public GameObject sippai2;
    public GameObject hayai;
    public GameObject osoi;
    int seikoukadouka;
    int seikoukadoukaok;
    float hayailast;
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
        lastok=0;
        underbarok=true;
        seikoukadouka=0;
        seikoukadoukaok=1;
        hayailast=0.0f;
    }

    void sp(){
        if(lastok>0){
            Instantiate(sindenzu);
            underbarok=false;
            lastok--;
        }else{
            Instantiate(aka);
            underbarok=false;
            
        }
        
    }

    void sinma()
    {
        if (taiminngu)
        {
            Instantiate(seikou);
            hayailast=Time.time;
            seikoukadouka=1;
            last = Time.realtimeSinceStartup;
            haato += 20;
            ookisa = transform.localScale; // ローカル変数に格納
            ookisa.x += 0.1f;
            ookisa.y += 0.1f;
            Debug.Log(ookisa);
            transform.localScale = ookisa;
            riseok = true;
            lastok+=1;

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
        Debug.Log(dameji.mdie);
        if(0f<=Time.time*100%100&&Time.time*100%100<=6f&&underbarok){
            sp();
        }
        if (/*Input.GetKey(KeyCode.Return) && sinmaok ||*/ sinmaok && SerialReceive.data==1)//retirnキーが押されれるor心マされた時sinmaokの時
        {
            sinma();
        }
        if(Input.GetKey(KeyCode.LeftCommand)&&Time.time-hayailast>=1.0&&taiminngu!=true||SerialReceive.data==1&&Time.time-hayailast>=1.0&&taiminngu!=true){
            Instantiate(sippai2);
            Instantiate(hayai);
            hayailast=Time.time;
        }
        if(Time.time * 100 % 100 > 7.0f && Time.time * 100 % 100 <8.0f){
            if(seikoukadouka==0&&seikoukadoukaok==1){
                Instantiate(sippai);
                Instantiate(osoi);
                seikoukadoukaok=0;
            }
            Debug.Log(seikoukadoukaok);
            
            
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
            
            //Debug.Log("%100=20");
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
