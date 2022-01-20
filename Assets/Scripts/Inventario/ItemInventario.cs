using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[System.Serializable]
public class ItemInventario
{
    public Item informacion {get; private set;}
    public int tamanio {get; private set;}

    public ItemInventario(Item data)
    {
        data = fuente;
        AddToStack();
    }

    public void AddToStack()
    {
        tamanio++;
    }

    public void RemoveFromStack()
    {
        tamanio--;
    }
}
