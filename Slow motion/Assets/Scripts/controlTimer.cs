using UnityEngine;

public class ControlTimer : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "InvisibleStartLine")
        {
            SetTimer(1);
        }

        if (collision.gameObject.name == "InvisibleFinishLine")
        {
            SetTimer(0);
        }
    }

    void SetTimer(int t)
    {
        Timer playerTimer = this.GetComponent<Timer>();
        playerTimer.startTimer = t;
    }
}
