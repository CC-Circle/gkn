using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batu : MonoBehaviour
{
    Vector3 ookisa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(bpm100.sinmaok);
        if(bpm100.sinmaok){

            ookisa=this.transform.position;//ugokuに現在の位置を代入
            ookisa.x=1000000f-10000f;//移動を追加
            this.transform.position=ookisa;//移動後のugokuを代入

        }else{
            ookisa=this.transform.position;//ugokuに現在の位置を代入
            ookisa.x=10000.0f-10000f;//移動を追加
            this.transform.position=ookisa;//移動後のugokuを代入
        }
    }
}