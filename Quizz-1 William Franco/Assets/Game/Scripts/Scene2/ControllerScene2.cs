using TMPro;
using UnityEngine;

public class ControllerScene2 : MonoBehaviour
{

    public Timer tiempoJuego;
    public TextMeshProUGUI txtCountApple;
    public TextMeshProUGUI txtCountOrange;
    public TextMeshProUGUI txtCountKiwi;
    public TextMeshProUGUI txtCountBanana;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        tiempoJuego.TimerStart();
       
    }

    // Update is called once per frame
    void Update()
    {
        GetTotalItem();
    }

    public void ShowGlobalTime()
    {
        Debug.Log("Tiempo total: " + GameManager.Instance.GlobalTime);
    }

    public void GetTimeScene()
    {

        GameManager.Instance.TotalTime(tiempoJuego.StopTime);
    }
    public void GetTotalItem()
    {
        txtCountApple.text = GameManager.Instance.TotalApple.ToString();
        txtCountOrange.text = GameManager.Instance.TotalOrange.ToString();
        txtCountKiwi.text = GameManager.Instance.TotalKiwi.ToString();
        txtCountBanana.text = GameManager.Instance.TotalBanana.ToString();
    }

}
