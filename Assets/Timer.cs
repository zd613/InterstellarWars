using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float time = 60;//カウントダウン開始時間


    float timeLeft = 0;

    private void Awake()
    {
        timeLeft = time;
    }

    private void Update()
    {
        timeLeft -= time;
        if (timeLeft < 0)
        {
            timeLeft = 0;
            print("end");


            //後で消す
            timeLeft = time;
        }
    }
}
