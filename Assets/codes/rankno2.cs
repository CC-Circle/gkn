using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rankno2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ActivateAllDisplays.rankazu>=1)
        gameObject.GetComponent<Text>().text = "No.2     " + ActivateAllDisplays.rank[3] ;
    }
}
