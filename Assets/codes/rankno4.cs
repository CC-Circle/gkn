using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rankno4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ActivateAllDisplays.rankazu>=3)
        gameObject.GetComponent<Text>().text = "No.4     " + ActivateAllDisplays.rank[1] ;
    }
}
