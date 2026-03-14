using UnityEngine;

public class ControllerScene1 : MonoBehaviour
{
    public Timer Tiempojuego;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetTimeScene()
    {
        GameManager.Instance.TotalTime(Tiempojuego.StopTime);
    }
}
