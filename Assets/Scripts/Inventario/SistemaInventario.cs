using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaInventario : MonoBehaviour
{
    //public static SistemaInventario current;
    private Dictionary<ItemData, ItemInventario> m_itemDictionary;
    public List<ItemInventario> inventario { get; private set; }

    private void Awake()
    {
        inventario = new List<ItemInventario>();
        m_itemDictionary = new Dictionary<ItemData, ItemInventario>();
    }

    public ItemInventario Get(ItemData dataReferencia)
    {
        if (m_itemDictionary.TryGetValue(dataReferencia, out ItemInventario value))
        {
            return value;
        }
        return null;
    }

    public void Add(ItemData dataReferencia)
    {
        if (m_itemDictionary.TryGetValue(dataReferencia, out ItemInventario value))
        {
            value.AddToStack();
        }
        else
        {
            ItemInventario newItem = new ItemInventario(dataReferencia);
            inventario.Add(newItem);
            m_itemDictionary.Add(dataReferencia, newItem);
        }
    }

    public void Remove(ItemData dataReferencia)
    {
        if (m_itemDictionary.TryGetValue(dataReferencia, out ItemInventario value))
        {
            value.RemoveFromStack();
        }
        if(value.stackSize == 0)
        {
            inventario.Remove(value);
            m_itemDictionary.Remove(dataReferencia);
        }
    }
}
