using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Dictionary<string, Coleccionable> coleccionablesDict = new Dictionary<string, Coleccionable>();
    [System.Serializable]
    public class Coleccionable
    {
        public string nombre;
        public string rareza;
        public int valor;
        public string icono;
    }

    [System.Serializable]
    public class GameData
    {
        public List<Coleccionable> colleccionables;
    }
    public static GameManager Instance { get; private set; }

    private float globalTime;

    private int totalApple = 0;
    private int totalOrange = 0;
    private int totalKiwi = 0;
    private int totalBanana = 0;

    void Awake()
    {
        CargarDatos();
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
    void CargarDatos()
    {
        string path = Path.Combine(Application.streamingAssetsPath, "GameData.json");

        if (!File.Exists(path))
        {
            Debug.LogError("No se encontró el JSON");
            return;
        }

        string json = File.ReadAllText(path);

        GameData data = JsonUtility.FromJson<GameData>(json);

        foreach (Coleccionable item in data.colleccionables)
        {
            coleccionablesDict[item.nombre.ToLower()] = item;
        }

        Debug.Log("JSON cargado correctamente");
    }
    public Coleccionable GetColeccionable(string nombre)
    {
        nombre = nombre.ToLower();

        if (coleccionablesDict.ContainsKey(nombre))
        {
            return coleccionablesDict[nombre];
        }

        Debug.LogError("No existe el coleccionable: " + nombre);
        return null;
    }

    public float GlobalTime => globalTime;
    public int TotalApple => totalApple;
    public int TotalOrange => totalOrange;
    public int TotalKiwi => totalKiwi;
    public int TotalBanana => totalBanana;
}