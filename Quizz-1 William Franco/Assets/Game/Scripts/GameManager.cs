using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private float globalTime = 0f;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void TotalTime(float timeScene)
    {
        globalTime += timeScene;
        Debug.Log("Tiempo acumulado: " + globalTime.ToString("F2") + " segundos"); // 👈 para verificar
    }

    public float GlobalTime
    {
        get { return globalTime; }
    }
}