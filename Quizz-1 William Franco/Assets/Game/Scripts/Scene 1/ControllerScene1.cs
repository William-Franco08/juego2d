using UnityEngine;

public class ControllerScene1 : MonoBehaviour
{
    public Timer Tiempojuego;

    private float startTime;

    void Start()
    {
        if (Tiempojuego != null)
        {
            startTime = Time.time;
        }
    }

    void OnDestroy()
    {
        if (GameManager.Instance != null)
        {
            float tiempoEscena = Time.time - startTime; 
            GameManager.Instance.TotalTime(tiempoEscena);
        }
    }
}