using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Planet : MonoBehaviour
{
    //パラメータ
    public int maxShips = 10;//船がこの星にいられる最大数
    public int increasementPerSecond;//1秒当たりに増える船の数

    //
    public Text numText;

    public int currentNumberOfShips = 0;//現在の船数

    float deltaTimeToIncrease;
    float time = 0;

    private void Awake()
    {
        deltaTimeToIncrease = 1.0f / increasementPerSecond;
    }

    private void Update()
    {
        time += Time.deltaTime;
        if (time > deltaTimeToIncrease)
        {
            while (true)
            {
                var t = time - deltaTimeToIncrease;

                if (t > 0)
                {
                    time = t;
                    if (currentNumberOfShips < maxShips)
                    {
                        currentNumberOfShips += 1;
                        if (numText != null)
                            numText.text = currentNumberOfShips.ToString();
                    }
                    continue;
                }
                break;
            }
        }
    }

}
