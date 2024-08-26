using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class owapoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Text>().text = "助けた人数; " + dameji.tasuketakazu +"人";//textを変更する
    }
}
