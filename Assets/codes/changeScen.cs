using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        points.point=0;
        points.cp=true;
        
    }
    //殴られた時の関数
    void naguru(){


        SceneManager.LoadScene("tutorial");
    }

    // Update is called once per frame
    void Update()
    {
        //もしリターンキーが押されたら関数「naguru」を起動する
        if(Input.GetKey(KeyCode.Return) ||  SerialReceive.data==1){
            naguru();
            owarisc.kill=false;
        }
    }
    void FixedUpdate(){

    }
}
