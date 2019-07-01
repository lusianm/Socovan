using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator: MonoBehaviour
{
    float speed = 60f;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(speed, speed, speed);
    }

    // Update is called once per frame
    void Update()
    {
        float RotateSpeed = speed * Time.deltaTime;
        transform.Rotate(RotateSpeed, RotateSpeed, RotateSpeed);
    }
}
