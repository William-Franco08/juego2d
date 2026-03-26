using UnityEngine;
using static GameManager;

using UnityEngine;

public class ItemRecolectable2 : MonoBehaviour
{
    [SerializeField] private string nombreItem;

    private Coleccionable data;

    void Start()
    {
        data = GameManager.Instance.GetColeccionable(nombreItem);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (data != null)
            {
                Debug.Log($"Recolectaste {data.nombre} | Valor: {data.valor} | Rareza: {data.rareza}");

                // Si quieres seguir usando tu sistema viejo:
                ItemData temp = new ItemData();
                temp.itemValue = data.valor;

                GameManager.Instance.TotalItem(temp);
            }

            Destroy(gameObject);
        }
    }
}