using UnityEngine;

public class SlowMotion : MonoBehaviour {

    public Camera normalCamera;
    public Camera frontCamera;

    public float slowdownFactor = 0.05f;
    public float slowdownLength = 2f;

    void Update() {
        float carCoordinate = transform.position.y;
        if (carCoordinate > 5.5) {
            normalCamera.enabled = false;
            frontCamera.enabled = true;
            SlowMo();
        }
        else {
            normalCamera.enabled = true;
            frontCamera.enabled = false;
            Time.timeScale += (1f / slowdownLength) * Time.unscaledDeltaTime;
            Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
        }
    }

    void SlowMo() {
        Time.timeScale = slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale * .02f;
    }
}
