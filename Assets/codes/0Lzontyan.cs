using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Lzontyan : MonoBehaviour
{
    Vector3 lookisa;
    bool llive;
    Vector3 lugoku;
    float lsindekara;
    int kn;
    
    // Start is called before the first frame update
    void Start()
    {
        llive =true;
        kn=spown.lspo;
        spown.lspo++;
        //MonoBehaviour dameji=new MonoBehaviour();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)&&llive&&kn==dameji.ldie&&Time.realtimeSinceStartup>=dameji.lct+0.1f){
            dameji.ldie++;
            dameji.taokazu++;
            llive=false;
            lsindekara=Time.realtimeSinceStartup;
            dameji.lct=Time.realtimeSinceStartup;
        }
        if(llive==false){
            lookisa=transform.position;//ugokuに現在の位置を代入
            lookisa.y+=0.1f;
            transform.position=lookisa;//移動後のugokuを代入
        }
        if(Time.realtimeSinceStartup>lsindekara+2&&llive==false){
            Destroy (this.gameObject);
        }
        if(llive&&lookisa.z>-5){
            lookisa=transform.position;//ugokuに現在の位置を代入
            lookisa.z-=0.01f;
            lookisa.x+=0.00625f;
            transform.position=lookisa;//移動後のugokuを代入
            
        }else if(llive&&lookisa.z<=-5&&lookisa.z>-7&&(int)(lookisa.z*10)%2==0){
            
            lookisa=transform.position;//ugokuに現在の位置を代入
            lookisa.z-=0.01f;
            lookisa.x+=0.00625f;
            transform.position=lookisa;//移動後のugokuを代入'
            gameObject.GetComponent<Renderer>().material.color = new Color(1, 1, 1);

        }else if(llive&&lookisa.z<=-5&&lookisa.z>-7&&(int)(lookisa.z*10)%2==-1){
            
            lookisa=transform.position;//ugokuに現在の位置を代入
            lookisa.z-=0.01f;
            lookisa.x+=0.00625f;
            transform.position=lookisa;//移動後のugokuを代入
            gameObject.GetComponent<Renderer>().material.color = new Color(1, 0, 0);

        }else if(llive&&lookisa.z<=-7){
            //Debug.Log("yobu");
            dameji.damejiok=true;
            dameji.ldie++;
            //GameObject instance = (GameObject)Instantiate(ldameji, new Vector3( 0, 0, 0), Quaternion.identity);
            Destroy (this.gameObject);
        }
    }
}
