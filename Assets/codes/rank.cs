using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rank : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        if(ActivateAllDisplays.rankazu==0){
            ActivateAllDisplays.rank[4]=points.point;
            
        }else if(ActivateAllDisplays.rankazu==1){
            ActivateAllDisplays.rank[3]=points.point;
            Array.Sort(ActivateAllDisplays.rank);
        }else if(ActivateAllDisplays.rankazu==2){
            ActivateAllDisplays.rank[2]=points.point;
            Array.Sort(ActivateAllDisplays.rank);
        }else if(ActivateAllDisplays.rankazu==3){
            ActivateAllDisplays.rank[1]=points.point;
            Array.Sort(ActivateAllDisplays.rank);
        }else if(ActivateAllDisplays.rankazu==4){
            ActivateAllDisplays.rank[0]=points.point;
            Array.Sort(ActivateAllDisplays.rank);
        }else {
            if(ActivateAllDisplays.rank[0]<points.point){
            ActivateAllDisplays.rank[0]=points.point;
            Array.Sort(ActivateAllDisplays.rank);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log(ActivateAllDisplays.rankazu);
        gameObject.GetComponent<Text>().text = "No.1     " + ActivateAllDisplays.rank[4] ;//textを変更する
    }
}
