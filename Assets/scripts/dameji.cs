using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dameji : MonoBehaviour
{
    int n;
    public static bool damejiok;
    Vector3 ookisa;
    bool okok;
    public static int ldie,mdie,rdie;
    public static float lct,mct,rct;
    public static int taokazu ,ukekazu;
    public static int tasuketakazu;
    // Start is called before the first frame update
    void Start()
    {
        okok=true;
        n=0;
        damejiok=false;
        ookisa=this.transform.position;//ugokuに現在の位置を代入
        ookisa.x=10000000;
        transform.position=ookisa;//移動後のugokuを代入
        ldie=1;
        mdie=1;
        rdie=1;
        taokazu=0;
        ukekazu=0;
        tasuketakazu=0;
    }

    // Update is called once per frame
    void Update()
    {
        tasuketakazu=points.point;
        if(damejiok){
            ookisa=this.transform.position;//ugokuに現在の位置を代入
            ookisa.x=1000;//移動を追加
            transform.position=ookisa;//移動後のugokuを代入
            bpm100.sinmaok=false;
            ukekazu++;
            if(okok){
                n=0;
                okok=false;
            }
        }
        n++;
        if(damejiok&&n>100){
            ookisa=this.transform.position;//ugokuに現在の位置を代入
            ookisa.x=10000000;
            transform.position=ookisa;//移動後のugokuを代入
            damejiok=false;
            
            okok=true;
        }
    }
}
