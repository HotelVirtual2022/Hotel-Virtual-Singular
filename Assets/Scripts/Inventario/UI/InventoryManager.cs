using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField]
    private GameObject m_slotPrefab;

    public SistemaInventario sistema;
    void Start()
    {
        //SistemaInventario.current.onInventoryChangedEvent += OnUpdateInventory;
    }

    private void Update()
    {
        OnUpdateInventory();
    }

    public void OnUpdateInventory()
    {
        foreach (Transform  t in transform)
        {
            Destroy(t.gameObject);
        }
        DrawInventory();
    }

    public void DrawInventory()
    {
        foreach (ItemInventario item in sistema.inventario)
        {
            AddInventorySlot(item);
        }
    }

    public void AddInventorySlot(ItemInventario item)
    {
        GameObject obj = Instantiate(m_slotPrefab);
        obj.transform.SetParent(transform, false);
        Slots slot = obj.GetComponent<Slots>();
        slot.Set(item);
    }
}
