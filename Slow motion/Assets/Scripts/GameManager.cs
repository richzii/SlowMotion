﻿using System.Collections;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Countdown
    public float currentTime;
    public float startingTime;
    [SerializeField] Text countdownTXT;

    // Speedometer
    public GameObject needle;
    private float startPosition = 220f, endPosition = -49f;
    private float desiredPosition;
    public float carSpeed;

    // Countdown
    void Start()
    {
        currentTime = startingTime;
        StartCoroutine(CountDown());
    }

    private IEnumerator CountDown()
    {
        CarUserControl control = FindObjectOfType<CarUserControl>(); //Atrodam control refernci ainaa. Var ari Serializet ar [SerializeField] un nemeklet
        control.enabled = false; //disablo komponentes darbibu (Start / Update izpildi)

        UpdateCountdownText(); // Nodrosinam, ka teksts jau sakuma parada counter vertibu

        while (currentTime > 0)
        {
            yield return new WaitForSeconds(1f); // nogaidam vienu sekundi
            currentTime--; //samazinam laika counter par vienu sekundi
            UpdateCountdownText(); // updeitojam tekxtu
        }

        countdownTXT.text = "";
        control.enabled = true;
    }

    private void UpdateCountdownText()
    {
        countdownTXT.text = currentTime.ToString("0");
    }

    // Speedometer
    public void updateNeedle()
    {
        desiredPosition = startPosition - endPosition;
        float temp = carSpeed / 180;
        needle.transform.eulerAngles = new Vector3(0, 0, (startPosition - temp * desiredPosition));
    }

    private void Update()
    {
        CarController CC = FindObjectOfType<CarController>();
        carSpeed = CC.CurrentSpeed;
        updateNeedle();
    }
}
