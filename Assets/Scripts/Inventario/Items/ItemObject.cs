using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public ItemData itemReferencia;
    private SistemaInventario inventario;
    private void Awake()
    {
        inventario = GameObject.FindGameObjectWithTag("SistemaInventario").GetComponent<SistemaInventario>();
    }
    public void Inventariar()
    {
        //Añade item a la lista y destruye GameObject de la escena
        inventario.Add(itemReferencia);
        Destroy(gameObject);
    }

    public void Dejar()
    {
        inventario.Remove(itemReferencia);
    }
}
