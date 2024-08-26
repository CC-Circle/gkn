//心臓を動かすためのコードです
//宣言した変数;ookisa,timerise,taiminngu,haato,ok,last,riseok,sinmaok,sinmadametime

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class bpm100 : MonoBehaviour
{
    //追加要so
      public SerialReceive SerialReceive;
     
    // Start is called before the first frame update
     Vector3 ookisa;//大きさを変更するための一時的なvec3
     Vector3 timerise;//心マを初期に戻すためのvec3
     public static bool taiminngu;//心マできるタイミングかどうかのbool
     public static int haato;//心マできている割合のint
     bool ok;//心臓が大きくなったり小さくなったりを１回のみにするためのbool
     float last;//最後に心マした時間を入れるためのfloat
     bool riseok;//心マを初期に戻していいかどうかのbool   
     public static bool sinmaok;
     float sinmadametime;
     bool sinmafalseok;

     
    void Start()
    {
        
        Time.timeScale = 5/3f;
        haato=0;
        sinmafalseok=true;
        ok=true;
        ookisa = transform.localScale; // ローカル変数に格納
            ookisa.x = 0.2f; 
            ookisa.y = 0.2f;
            transform.localScale = ookisa; 
        last=0.0f;
        riseok=false;
        sinmaok=true;
    }       

    void sinma(){
        if(taiminngu){
            last=Time.realtimeSinceStartup;
            haato+=20;
            ookisa = transform.localScale; // ローカル変数に格納
            ookisa.x += 0.1f; 
            ookisa.y += 0.1f;
            transform.localScale = ookisa;
            riseok=true; 

            if(haato>=100){
                haato=0;
                points.cp=true;
                points.point+=1;
                ookisa = transform.localScale; // ローカル変数に格納
                ookisa.x = 0.25f; 
                ookisa.y = 0.25f;
                transform.localScale = ookisa; 

            }
            taiminngu=false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        int getdata;
        int.TryParse(SerialReceive.data, out getdata);
        if(Input.GetKey(KeyCode.Return)||getdata == 1){
            sinma();
        }
        //Debug.Log(Time.time);
        if(Time.time*100%100>97.0f||Time.time*100%100<3.0f){
            if(ok){
            ookisa = transform.localScale; // ローカル変数に格納
            ookisa.x += 0.05f; 
            ookisa.y += 0.05f;
            transform.localScale = ookisa; 
            
            taiminngu=true;
            ok=false;
            //Debug.Log("%100=0");
            }
           

        }
        if(Time.time*100%100>7.0f&&Time.time*100%100<13.0f){
            if(ok==false){
            ookisa = transform.localScale; // ローカル変数に格納
            ookisa.x -= 0.05f; 
            ookisa.y -= 0.05f;
            transform.localScale = ookisa; 
            taiminngu=false;
            ok=true;
            }
            //Debug.Log("%100=20");
        }
        if(Time.realtimeSinceStartup-last>=10&&riseok){
            timerise = transform.localScale; // ローカル変数に格納
                timerise.x = 0.2f; 
                timerise.y = 0.2f;
                transform.localScale = timerise; 
                riseok=false;
        }
        if(sinmaok!=true&&sinmafalseok){
            sinmafalseok=false;
            sinmadametime=Time.realtimeSinceStartup;
        }
        if(Time.realtimeSinceStartup-sinmadametime>=10&&sinmaok!=true){
            sinmaok=true;
           sinmafalseok=true;
        }
    }
}
