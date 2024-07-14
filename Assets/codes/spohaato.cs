using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spohaato : MonoBehaviour
{
    public static bool spoh;
    public GameObject haato;
    public GameObject waku;
    public GameObject sinin;
    public GameObject batu;
    public GameObject sh;
    public GameObject sr;
    public static bool spohok;
    public Vector3 Position1;
    public Vector3 Position2;
    public Vector3 Position3;
    public Vector3 Position4;
    public Vector3 Position5;
    public Vector3 Position6;
    public Vector3 mawasinin;

    // Start is called before the first frame update
    void Start()
    {
        spoh=true;
        spohok=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(spoh&&spohok){
            Quaternion rotation = Quaternion.Euler(mawasinin);
            Instantiate(haato, Position1, Quaternion.identity);
            Instantiate(waku, Position2, Quaternion.identity);
            Instantiate(sinin, Position3,rotation);
            Instantiate(batu, Position4, Quaternion.identity);
            Instantiate(sh,Position5, Quaternion.identity);
            Instantiate(sr, Position6, Quaternion.identity);
            spoh=false;
        }
    }
}
