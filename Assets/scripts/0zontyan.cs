using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class zontyan : MonoBehaviour
{
    Vector3 ookisa;
    bool live;
    Vector3 ugoku;
    float sindekara;
    int kn;
    // Start is called before the first frame update
    void Start()
    {
        kn=spown.mspo;
        spown.mspo++;
        live =true;
        //MonoBehaviour dameji=new MonoBehaviour();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)&&live&&kn==dameji.mdie&&Time.realtimeSinceStartup>=dameji.mct+0.1f){
            dameji.mdie++;
            dameji.taokazu++;
            live=false;
            sindekara=Time.realtimeSinceStartup;
            dameji.mct=Time.realtimeSinceStartup;
        }
        if(live==false){
            ookisa=transform.position;//ugokuに現在の位置を代入
            ookisa.y+=0.1f;
            transform.position=ookisa;//移動後のugokuを代入
        }
        if(Time.realtimeSinceStartup>sindekara+2&&live==false){
            Destroy (this.gameObject);
        }
        if(live&&ookisa.z>-7){
            ookisa=transform.position;//ugokuに現在の位置を代入
            ookisa.z-=0.01f;
            transform.position=ookisa;//移動後のugokuを代入
            
        }else if(live&&ookisa.z<=-7){
            
            dameji.damejiok=true;
            dameji.mdie++;
            
            //GameObject instance = (GameObject)Instantiate(ldameji, new Vector3( 0, 0, 0), Quaternion.identity);
            Destroy (this.gameObject);
        }
    }
}
