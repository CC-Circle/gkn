using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

public class ido1no1 : MonoBehaviour
{
    // Start is called before the first frame update
    private bool ataru;//このオブジェクトが当たり判定にいるかどうかのbool
    private Vector3 ugoku;//このオブジェクトが動くためのVec3
    private Quaternion mawaru;//回転させるためのQuaternion
    public int nedan;//このオブジェクトを倒した時の値段
    private int sinda;//この人が死んでいるかどうかのboolとしてのint
    static public bool start;//動き出したかどうかのbool
    
    void Start()
    {
        ataru=false;//初期化
        nedan=1500;//値段の決定
        sinda=0;//初期化
        start=false;
        MonoBehaviour points=new MonoBehaviour();//ほかのスクリプトを呼ぶための関数（御呪い）
        MonoBehaviour naguru=new MonoBehaviour();//同上
    }

    // Update is called once per frame
    void Update()
    {
        if(start){//始まっているかどうか
            if(sinda==0){//死んでいないなら
                ugoku=transform.position;//ugokuに現在の位置を代入
                ugoku.x+=-0.01f;//移動を追加
                transform.position=ugoku;//移動後のugokuを代入
            }else{
                ugoku=transform.position;//ugokuに現在の位置を代入
            ugoku.y+=0.001f;//移動を追加
                transform.position=ugoku;//移動後のugokuを代入
                mawaru=transform.rotation;//mawaruに現在の回転を代入
                mawaru.z+=0.1f;//回転を追加
                transform.rotation=mawaru;//回転後のmawaruを代入
            }
            if(transform.position.x<=5.5f&&transform.position.x>=-5.5f&&ataru!=true){//中にいてかつ当たり判定がoffの時
                ataru=true;//ataruをtrueにする
                //Debug.Log("in");//入ったらinをデバッグログに入れる
            }
            if(transform.position.x<=-5.5f&&ataru!=false){//s
                ataru=false;
                //Debug.Log("out");
            }
            if(naguru.panti==1&&sinda==0&&ataru){
                points.point=points.point+nedan;
                points.cp=true;
                sinda=1;
            }
    }
    }
}
