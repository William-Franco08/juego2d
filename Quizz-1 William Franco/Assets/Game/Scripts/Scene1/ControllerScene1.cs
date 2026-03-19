using UnityEngine;

public class ControllerScene1 : MonoBehaviour
{

    public Timer tiempoJuego;


    
    void Start()
    {
        tiempoJuego.TimerStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetTimeScene() {
 
        GameManager.Instance.TotalTime(tiempoJuego.StopTime);
    }

    
}
