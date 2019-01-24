using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public float speed = 2;
    public Transform planet;
    public float r = 1;//半径
    public float rotationSpeed = 2;//回転角度(euler)/sec


    Vector3 center;
    private void Awake()
    {
        center = planet.transform.position;
    }

    private void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 10, Color.blue);
        Debug.DrawRay(transform.position, transform.right * 10, Color.red);

        RotateAroundPlanet();
    }

    void RotateAroundPlanet()
    {
        var speed = r * rotationSpeed;

        var distance = Vector3.Distance(transform.position, center);
        var a = speed * speed / distance;

        transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);


        transform.position = transform.position + transform.forward * speed * Time.deltaTime;
    }
}
