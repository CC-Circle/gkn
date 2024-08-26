using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sinechange2 : MonoBehaviour
{
    public static int  killkazu;
    // Start is called before the first frame update
    void Start()
    {
        killkazu=0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Tab)){
            Debug.Log(killkazu);
        }
        if(killkazu==3){
            SceneManager.LoadScene("countdown");
        }
    }
}
