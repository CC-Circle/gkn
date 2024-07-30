using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rankno5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ActivateAllDisplays.rankazu>=4)
        gameObject.GetComponent<Text>().text = "No.5     " + ActivateAllDisplays.rank[0] ;
    }
}
