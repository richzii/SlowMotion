using System.Collections;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;

public class controlTimer : MonoBehaviour
{
    CarUserControl control = FindObjectOfType<CarUserControl>();
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "InvisibleStartLine")
        {
            setTimer(1);
        }

        if (collision.gameObject.name == "InvisibleFinishLine")
        {
            setTimer(0);
        }
    }

    void setTimer(int t)
    {
        timer playerTimer = this.GetComponent<timer>();
        playerTimer.startTimer = t;
    }
}
