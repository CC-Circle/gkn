using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScen : MonoBehaviour
{
     public SerialReceive SerialReceive;
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
        int getdata;
        int.TryParse(SerialReceive.data, out getdata);
        if(Input.GetKey(KeyCode.Return)|| getdata == 1){
            naguru();
        }
    }
    void FixedUpdate(){

    }
}
