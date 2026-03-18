using UnityEngine;

public class ControllerScene3 : MonoBehaviour
{
    void Start()
    {
        if (GameManager.Instance != null)
        {
            Debug.Log("Tiempo total: " + GameManager.Instance.GlobalTime.ToString("F2") + " segundos");;
        }
        else
        {
            Debug.LogWarning("GameManager no encontrado");
        }
    }
}