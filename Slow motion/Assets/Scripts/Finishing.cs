using System.Collections;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;

public class Finishing : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        CarUserControl control = FindObjectOfType<CarUserControl>();
        if (collision.gameObject.name == "InvisibleFinishLine") {
            Debug.Log("Car has reached the finish");
            control.enabled = false; 
        }
    }
}
