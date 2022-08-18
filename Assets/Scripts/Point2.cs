using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point2 : MonoBehaviour
{
    public Rigidbody danger1rridg;
    int speed = 2000;
    private int RandoMs = 0;

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        RandoMs = Random.Range(1, 3);
        if (RandoMs == 1)
        {
            danger1rridg.AddForce(speed * Time.deltaTime, 0, 0);
        }
        if (RandoMs == 2)
        {
            danger1rridg.AddForce(0, 0, speed * Time.deltaTime);
        }
        RandoMs = 0;
    }
}
