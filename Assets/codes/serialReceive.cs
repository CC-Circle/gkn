using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerialReceive : MonoBehaviour
{
    public SerialHandler serialHandler;

    public static int data;//おされてるかどうかのboolとしてのint
    void Start()
    {
        //信号を受信したときに、そのメッセージの処理を行う
        try {
            serialHandler.OnDataReceived += OnDataReceived;
        } catch(System.Exception e) {
            Debug.LogWarning(e.Message);
        }
    }

    //受信した信号(message)に対する処理
    void OnDataReceived(string message)
    {
        //if(message != "") {
            //data = int.Parse(message);
        //}
        try
        {
            data = int.Parse(message);
            // Debug.Log(data);//Unityのコンソールに受信データを表示
        }
        catch (System.Exception e)
        {
            Debug.LogWarning(e.Message);//エラーを表示
            Debug.LogWarning("hoge");//エラーを表示  
        } 
    }
}