using System.Collections;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float currentTime;
    public float startingTime;
    [SerializeField] Text countdownTXT;

    public static int MinuteCount;
    public static int SecondCount;
    public static float MilliCount;
    public static string MilliDisplay;

    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;

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
}
