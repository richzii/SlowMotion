using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interpolation : MonoBehaviour
{
    Vector3 startingPosition;
    Vector3 endingPosition;

    float time;
    public float flightTime;

    void Start()
    {
        startingPosition = new Vector3(195, 22, 4);
        endingPosition = new Vector3(5, 22, 170);
    }

    void Update()
    {
        time += Time.deltaTime;
        transform.position = Vector3.Lerp(startingPosition, endingPosition, time/flightTime);
    }
}
