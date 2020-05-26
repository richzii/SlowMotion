using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour {

    public GameObject LapStart;
    public GameObject LapEnd;

    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;

    public GameObject EndResult;

    void OnTriggerEnter() {
        TimeManager.MinuteCount = 0;
        TimeManager.SecondCount = 0;
        TimeManager.MilliCount = 0;

        LapStart.SetActive(true);
        LapEnd.SetActive(false);
    }
}
