using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class tyumnaguru : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 ookisa;
    float sindekara;
    bool die;
    bool ok;
    void Start()
    {
        die=false;
        ok=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            die=true;
        }
        if(die){
            ookisa=transform.position;//ugokuに現在の位置を代入
            ookisa.y+=0.1f;
            transform.position=ookisa;
        }
        if(die&&ok){
            
            sindekara=Time.realtimeSinceStartup;
            ok=false;
        }
        if(Time.realtimeSinceStartup-sindekara>=2&&die){
            sinechange2.killkazu++;
            Destroy (this.gameObject);
        }
    }
}
