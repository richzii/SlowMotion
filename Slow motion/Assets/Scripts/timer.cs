using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class timer : MonoBehaviour
{
    public GameObject Timer;
    public float startTimer = 0;
    private float time;

    void Update() {
        if (startTimer == 0) {
            Timer.GetComponent<Text>().text = "";
        }
        else {

            time += Time.deltaTime;

            var minutes = time / 60; 
            var seconds = time % 60;
            var fraction = (time * 100) % 100;

            Timer.GetComponent<Text>().text = string.Format("{0:00} : {1:00} : {2:000}", minutes, seconds, fraction);
        }
    }
}