using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rankno3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ActivateAllDisplays.rankazu>=2)
        gameObject.GetComponent<Text>().text = "No.3     " + ActivateAllDisplays.rank[2] ;
    }
}
