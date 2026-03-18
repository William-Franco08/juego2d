using UnityEngine;

public class ControllerScene2 : MonoBehaviour
{
    public Timer Tiempojuego;

    void Start()
    {
        if (Tiempojuego != null)
        {
            Tiempojuego.TimerStart();
        }
    }

    void OnDestroy()
    {
        if (GameManager.Instance != null && Tiempojuego != null)
        {
            Tiempojuego.TimerStop();
            GameManager.Instance.TotalTime(Tiempojuego.StopTime);
        }
    }
}