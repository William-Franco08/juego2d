using TMPro;
using UnityEngine;

public class ControllerScene2 : MonoBehaviour
{
    public Timer tiempoJuego;
    public TextMeshProUGUI txtCountApple;
    public TextMeshProUGUI txtCountOrange;
    public TextMeshProUGUI txtCountKiwi;
    public TextMeshProUGUI txtCountBanana;

    void Start()
    {
        if (tiempoJuego != null)
            tiempoJuego.TimerStart();
        else
            Debug.LogError("tiempoJuego es NULL");
        Debug.Log(GameManager.Instance);
    }

    void Update()
    {
        GetTotalItem();
    }

    public void GetTotalItem()
    {
        if (GameManager.Instance == null)
        {
            Debug.LogError("GameManager.Instance es NULL");
            return;
        }

        if (txtCountApple != null)
            txtCountApple.text = GameManager.Instance.TotalApple.ToString();

        if (txtCountOrange != null)
            txtCountOrange.text = GameManager.Instance.TotalOrange.ToString();

        if (txtCountKiwi != null)
            txtCountKiwi.text = GameManager.Instance.TotalKiwi.ToString();

        if (txtCountBanana != null)
            txtCountBanana.text = GameManager.Instance.TotalBanana.ToString();
    }
}