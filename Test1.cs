using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    private float countup = 0.0f;
    public float timelimit_x;
    public float timelimit_y;
    public float timelimit_z;
    public float angle;


     // Update is called once per frame
    void Update()
    {
        //時間をカウントする
        countup += Time.deltaTime;
 
       
        if((countup >= timelimit_x)&(timelimit_y>countup))
        {
        // x軸を軸にして毎秒2度、回転させるQuaternionを作成（変数をrotとする）
        Quaternion rot = Quaternion.AngleAxis(angle, Vector3.right);
        // 現在の自信の回転の情報を取得する。
        Quaternion q = this.transform.rotation;
        // 合成して、自身に設定
        this.transform.rotation = q * rot;
        }

        else if((countup >= timelimit_y)&(timelimit_z>countup))
        {
        // y軸を軸にして毎秒2度、回転させるQuaternionを作成（変数をrotとする）
        Quaternion rot = Quaternion.AngleAxis(angle, Vector3.up);
        // 現在の自信の回転の情報を取得する。
        Quaternion q = this.transform.rotation;
        // 合成して、自身に設定
        this.transform.rotation = q * rot;
        }

        else if(countup >= timelimit_z)
        {
         // z軸を軸にして毎秒2度、回転させるQuaternionを作成（変数をrotとする）
        Quaternion rot = Quaternion.AngleAxis(angle, Vector3.forward);
        // 現在の自信の回転の情報を取得する。
        Quaternion q = this.transform.rotation;
        // 合成して、自身に設定
        this.transform.rotation = q * rot;
        }

        
    }
}
