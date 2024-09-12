using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ActivateAllDisplays : MonoBehaviour
{
    public static int[] rank;
    public static int rankazu;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log ("displays connected: " + Display.displays.Length);
            // Display.displays[0] は主要なデフォルトのディスプレイで、常にオンです。ですから、インデックス 1 から始まります。
            // その他のディスプレイが使用可能かを確認し、それぞれをアクティブにします。
    
        for (int i = 1; i < Display.displays.Length; i++)
            {
                Display.displays[i].Activate();
            }
        rank = new int[5]{0,0,0,0,0};
        rankazu=0;
        Application.targetFrameRate=60;
    }

    // Update is called once per frame
    void Update()
    {
        SceneManager.LoadScene("Title");
    }
}
