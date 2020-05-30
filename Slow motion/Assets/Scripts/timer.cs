using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject TimerLabel;
    public float startTimer = 0;
    private float time;

    void Update() {
  
        if (startTimer == 0) {
            TimerLabel.GetComponent<Text>().text = "";
        }
        else {
            time += Time.deltaTime;

            var minutes = time / 60; 
            var seconds = time % 60;
            var fraction = (time * 100) % 100;

            TimerLabel.GetComponent<Text>().text = string.Format("{0:00} : {1:00} : {2:000}", minutes, seconds, fraction);
        }
    }
}