using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class owarisc : MonoBehaviour
{
    public static bool kill;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftShift)){
            bpm100.taiminngu=false;
            bpm100.haato=0;
            bpm100.sinmaok=true;
            bpm100.sinmaokok=true;
            dameji.damejiok=false;
            dameji.ldie=1;
            dameji.mdie=1;
            dameji.rdie=1;
            dameji.taokazu=0;
            dameji.ukekazu=0;
            points.point=0;
            points.cp=true;
            sinechange2.killkazu=0;
            spown.lspo=1;
            spown.mspo=1;
            spown.rspo=1;
            kill=true;
            SceneManager.LoadScene("Title");
        }
    }
}
