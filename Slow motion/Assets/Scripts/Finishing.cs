using System.Collections;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;

public class Finishing : MonoBehaviour
{
    public Camera normalCamera;
    public Camera finishCamera;

    void OnCollisionEnter(Collision collision)
    {
        CarUserControl control = FindObjectOfType<CarUserControl>();
        if (collision.gameObject.name == "InvisibleFinishLine") {
            Debug.Log("Car has reached the finish");
            control.enabled = false;
            ShowFinish();
        }

        void ShowFinish() {
            normalCamera.enabled = false;
            finishCamera.enabled = true;
        }
    }
}
