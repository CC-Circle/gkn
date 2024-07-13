using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class jikan : MonoBehaviour
{
    float hajime;
    float debag;
    [SerializeField] private int ge_mujikan;
    // Start is called before the first frame update
    void Start()
    {
        hajime=Time.realtimeSinceStartup;
        
        debag=0;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.Tab)){
            debag+=1f;
            Debug.Log(debag);
        }
        int jikan =(int)Time.realtimeSinceStartup;
        int nokori=(int)(ge_mujikan-jikan+hajime-debag);
        gameObject.GetComponent<Text>().text = "残り時間;" + nokori +"秒";
        if(nokori<0){
            SceneManager.LoadScene("owari");
        }
    }
}
