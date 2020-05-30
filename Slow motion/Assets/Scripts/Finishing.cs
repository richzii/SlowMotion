using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;

public class Finishing : MonoBehaviour
{
    public Camera normalCamera;
    public Camera finishCamera;
    [SerializeField] Text resultTxt;
    [SerializeField] Text lapTimeTxt;

    public float carSpeed;
    static float endSpeed = 0.0f;

    void OnCollisionEnter(Collision collision)
    {
        CarUserControl control = FindObjectOfType<CarUserControl>();
        if (collision.gameObject.name == "InvisibleFinishLine") {
            Debug.Log("Car has reached the finish");
            control.enabled = false;
            ShowFinish();
            if (lapTimeTxt.text != "") {
                resultTxt.text = lapTimeTxt.text;
            }
        }

        void ShowFinish() {
            finishCamera.depth = Camera.main.depth + 1;
        }
    }
}
