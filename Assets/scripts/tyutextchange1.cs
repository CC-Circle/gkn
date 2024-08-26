using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class tyutextchange1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        gameObject.GetComponent<Text>().text  ="現在進捗度"+ bpm100.haato +"%";
        if(points.point==1){
            SceneManager.LoadScene("tutorial2");
        }
    }
}
