using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public ItemData itemReferencia;
    public SistemaInventario inventario;
    private void Awake()
    {
        inventario = GameObject.FindGameObjectWithTag("SistemaInventario").GetComponent<SistemaInventario>();
    }
    public void Inventariar()
    {
        inventario.Add(itemReferencia);
        Destroy(gameObject);
    }

    public void Dejar()
    {
        inventario.Remove(itemReferencia);
    }
}
