//このコードは助けた人数のカウントするコードです。
//宣言した変数;point,cp


using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
    public static int point;//助けた人数を入れるint
    public static bool cp;//ポイントが変わったかどうか検知するbool
    // Start is called before the first frame update
    void Start()
    {
        point=0;//初期化
        changepoint();//初期化
    }

    void changepoint(){
        gameObject.GetComponent<Text>().text = "助けた人数; " + point +"人";//textを変更する
    }

    // Update is called once per frame
    void Update()
    {
        if(cp){
            cp=false;//ポイントが変わった判定を戻す
            changepoint();//textを変更する
        }
    }
}
