using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private float globalTime;

    private int totalApple = 0;
    private int totalOrange = 0;
    private int totalKiwi = 0;
    private int totalBanana = 0;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void TotalTime(float timeScene)
    {
        globalTime += timeScene;
    }

    public void TotalItem(ItemData item)
    {
        switch (item.itemType)
        {
            case ItemType.Apple:
                totalApple += item.itemValue;
                break;
            case ItemType.Orange:
                totalOrange += item.itemValue;
                break;
            case ItemType.Kiwi:
                totalKiwi += item.itemValue;
                break;
            case ItemType.Banana:
                totalBanana += item.itemValue;
                break;
        }
    }

    public float GlobalTime => globalTime;
    public int TotalApple => totalApple;
    public int TotalOrange => totalOrange;
    public int TotalKiwi => totalKiwi;
    public int TotalBanana => totalBanana;
}