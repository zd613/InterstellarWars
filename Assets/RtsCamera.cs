using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RtsCamera : MonoBehaviour
{
    //カメラ移動スピード
    public float speed = 10;


    //制限
    public float minX = -10;
    public float maxX = 10;
    public float minZ = -10;
    public float maxZ = 10;

    private void LateUpdate()
    {
        Move();
    }

    //vertical:z horizontal:x として移動
    void Move()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        var movement = new Vector3(horizontal, 0, vertical);
        var newPos = transform.position + movement * Time.deltaTime * speed;
        if (newPos.x < minX)
        {
            newPos.x = minX;
        }
        else if (newPos.x > maxX)
        {
            newPos.x = maxX;
        }

        if (newPos.z < minZ)
        {
            newPos.z = minZ;
        }
        else if (newPos.z > maxZ)
        {
            newPos.z = maxZ;
        }
        transform.position = newPos;
    }
}
