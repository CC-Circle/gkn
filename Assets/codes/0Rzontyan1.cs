using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Rzontyan : MonoBehaviour
{
    Vector3 rookisa;
    bool rlive;
    Vector3 rugoku;
    float rsindekara;
    int kn;
    public AudioClip audioClip3;
    private AudioSource audioSource;
    bool ok;
    
    // Start is called before the first frame update
    void Start()
    {
        rlive =true;
        kn=spown.rspo;
        spown.rspo++;
        //MonoBehaviour dameji=new MonoBehaviour();
        audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.clip = audioClip3;
            ok=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)&&rlive&&kn==dameji.rdie&&Time.realtimeSinceStartup>=dameji.rct+0.1f){
            dameji.rdie++;
            dameji.taokazu++;
            rlive=false;
            audioSource.Stop();  
            rsindekara=Time.realtimeSinceStartup;
            dameji.rct=Time.realtimeSinceStartup;
        }
        if(rlive==false){
            rookisa=transform.position;//ugokuに現在の位置を代入
            rookisa.y+=0.1f;
            transform.position=rookisa;//移動後のugokuを代入
        }
        if(Time.realtimeSinceStartup>rsindekara+2&&rlive==false){
            audioSource.Stop();  
            Destroy (this.gameObject);
        }
        if(rlive&&rookisa.z>-4){
            rookisa=transform.position;//ugokuに現在の位置を代入
            rookisa.z-=0.01f;
            rookisa.x-=0.00625f;
            transform.position=rookisa;//移動後のugokuを代入
            
        }else if(rlive&&rookisa.z<=-4&&rookisa.z>-7&&(int)(rookisa.z*10)%2==0){
            
            rookisa=transform.position;//ugokuに現在の位置を代入
            rookisa.z-=0.01f;
            rookisa.x-=0.00625f;
            transform.position=rookisa;//移動後のugokuを代入
            gameObject.GetComponent<Renderer>().material.color = new Color(1, 1, 1);

        }else if(rlive&&rookisa.z<=-4&&rookisa.z>-7&&(int)(rookisa.z*10)%2==-1){
            
            rookisa=transform.position;//ugokuに現在の位置を代入
            rookisa.z-=0.01f;
            rookisa.x-=0.00625f;
            transform.position=rookisa;//移動後のugokuを代入
            gameObject.GetComponent<Renderer>().material.color = new Color(1, 0, 0);

        }else if(rlive&&rookisa.z<=-7){
            dameji.damejiok=true;
            dameji.rdie++;
            audioSource.Stop();  
            //GameObject instance = (GameObject)Instantiate(ldameji, new Vector3( 0, 0, 0), Quaternion.identity);
            Destroy (this.gameObject);
        }
        if(rookisa.z<=-4&&ok){
            ok=false;
            audioSource.Play ();
        }
    }
}
