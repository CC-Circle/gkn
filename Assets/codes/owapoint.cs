using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class owapoint : MonoBehaviour
{
    public static int opoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        opoint=points.point;
        gameObject.GetComponent<Text>().text = "助けた人数: " + opoint +"人";//textを変更する
    }
}
