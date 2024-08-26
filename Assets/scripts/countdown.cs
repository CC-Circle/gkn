using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countdown : MonoBehaviour
{
    float hajime;
    // Start is called before the first frame update
    void Start()
    {
        hajime=Time.realtimeSinceStartup;
    }

    // Update is called once per frame
    void Update()
    {
        int jikan=(int)(4-Time.realtimeSinceStartup+hajime);
        gameObject.GetComponent<Text>().text =  ""+jikan ;
        if(jikan==0){
            SceneManager.LoadScene("soseigame");
        }
    }
}
