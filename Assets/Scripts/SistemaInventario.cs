using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaInventario : MonoBehaviour
{
    //private Dictionary<Item, ItemInventario> m_itemDictionary;
    public List<ItemInventario> invetario{get; private set;}

    void Awake()
    {
        invetario = new List<ItemInventario>();
        //m_itemDictionary = new Dictionary<Item, ItemInventario>();
    }
    
    void Add (ItemInventario dataReferencia)
    {
        /*if(m_itemDictionary.TryGetValue(dataReferencia, out ItemInventario value))
        {
            value.AddToStack();
        }*/
        //ItemInventario newItem = new ItemInventario(dataReferencia);
        invetario.Add(dataReferencia);
        //m_itemDictionary.Add(dataReferencia, dataReferencia);
    }

    void Remove (ItemInventario dataReferencia)
    {
        /*if(m_itemDictionary.TryGetValue(dataReferencia, out ItemInventario value))
        {
            value.RemoveFromStack();

            if(value.stackSize == 0)
            {
                
            }
        }*/
        invetario.Remove(dataReferencia);
        //m_itemDictionary.Remove(dataReferencia);
    }
}
