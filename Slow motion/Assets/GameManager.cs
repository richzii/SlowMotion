using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Speedometer
    //public CarController CC;
    //public GameObject needle;
    //private float startPosition = 220f, endPosition = -41;
    //private float expectedPosition;
    //public float carSpeed;
    
    // Countdown timer - not done
    public float currentTime;
    public float startingTime;
    [SerializeField] Text countdownTXT;

    void Start() {
        currentTime = startingTime;
    }

    void Update() {
        currentTime -= 1 * Time.deltaTime;
        countdownTXT.text = currentTime.ToString("0");

        if (currentTime <= 0) {
            countdownTXT.text = "";
        }
    }

    // For some reason this is not working - can't get the speed for speedometer.
    //private void FixedUpdate() {
    //    carSpeed = CC.CurrentSpeed;
    //    updateNeedle();
    //}

    //public void updateNeedle() {
    //    expectedPosition = startPosition - endPosition;
    //    float temp = carSpeed / 180;
    //    needle.transform.eulerAngles = new Vector3(0, 0, (startPosition - temp * expectedPosition));
    //}
}
