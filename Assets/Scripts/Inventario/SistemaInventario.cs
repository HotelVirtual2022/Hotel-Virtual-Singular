using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaInventario : MonoBehaviour
{
    public InventoryManager managerInventario;
    private Dictionary<ItemData, ItemInventario> m_itemDictionary;
    public List<ItemInventario> inventario { get; private set; }

    private void Awake()
    {
        //Genera nuevas listas de items y stacks
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
        //Si el objeto existe dentro de la lista, añade uno al stack de este. Si no existe lo añade a la lista
        if (m_itemDictionary.TryGetValue(dataReferencia, out ItemInventario value))
        {
            value.AddToStack();

            //Actualiza el inventario dentro del juego
            managerInventario.OnUpdateInventory();
        }
        else
        {
            ItemInventario newItem = new ItemInventario(dataReferencia);
            inventario.Add(newItem);
            m_itemDictionary.Add(dataReferencia, newItem);
            
            //Actualiza el inventario dentro del juego
            managerInventario.OnUpdateInventory();
        }
    }

    public void Remove(ItemData dataReferencia)
    {
        //Si el objeto existe dentro de la lista, quita uno al stack de este. Si no existe lo elimina a la lista
        if (m_itemDictionary.TryGetValue(dataReferencia, out ItemInventario value))
        {
            value.RemoveFromStack();

            //Actualiza el inventario dentro del juego
            managerInventario.OnUpdateInventory();
        }
        if(value.stackSize == 0)
        {
            inventario.Remove(value);
            m_itemDictionary.Remove(dataReferencia);

            //Actualiza el inventario dentro del juego
            managerInventario.OnUpdateInventory();
        }
    }
}
