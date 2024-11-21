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
    public AudioClip audioClip2;
    private AudioSource audioSource;
    bool ok;
    // Start is called before the first frame update
    void Start()
    {
        kn=spown.mspo;
        spown.mspo++;
        live =true;
        //MonoBehaviour dameji=new MonoBehaviour();
        audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.clip = audioClip2;
            ok=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Return)&&live){
            Debug.Log("sinda");
            dameji.mdie++;
            dameji.taokazu++;
            live=false;
            audioSource.Stop();  
            sindekara=Time.realtimeSinceStartup;
            dameji.mct=Time.realtimeSinceStartup;
        }
        if(live==false){
            ookisa=transform.position;//ugokuに現在の位置を代入
            ookisa.y+=0.1f;
            transform.position=ookisa;//移動後のugokuを代入
        }
        if(Time.realtimeSinceStartup>sindekara+2&&live==false){
            audioSource.Stop();  
            Destroy (this.gameObject);
        }
        if(live&&ookisa.z>-5){
            ookisa=transform.position;//ugokuに現在の位置を代入
            ookisa.z-=0.01f;
            transform.position=ookisa;//移動後のugokuを代入
            
        }else if(live&&ookisa.z<-5&&ookisa.z>-7&&(int)(ookisa.z*10)%2==0){
            
            gameObject.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
            //しろ
            ookisa=transform.position;//ugokuに現在の位置を代入
            ookisa.z-=0.01f;
            transform.position=ookisa;//移動後のugokuを代入
            
            
        }else if(live&&ookisa.z<-5&&ookisa.z>-7&&(int)(ookisa.z*10)%2==-1){
            
            gameObject.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
            //あか
            ookisa=transform.position;//ugokuに現在の位置を代入
            ookisa.z-=0.01f;
            transform.position=ookisa;//移動後のugokuを代入

        }else if(live&&ookisa.z<=-7){
            
            dameji.damejiok=true;
            dameji.mdie++;
            Destroy (this.gameObject);  
            audioSource.Stop();
            
            //GameObject instance = (GameObject)Instantiate(ldameji, new Vector3( 0, 0, 0), Quaternion.identity);
           
        }
        //Debug.Log((int)ookisa.z%2);
        if(ookisa.z<=-5.5&&ok){
            ok=false;
            audioSource.Play ();
        }
         
    }
    
}
