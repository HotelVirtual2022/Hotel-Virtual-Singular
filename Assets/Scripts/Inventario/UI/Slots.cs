using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slots : MonoBehaviour
{
    [SerializeField]
    private Image m_icon;

    [SerializeField]
    private Text m_label;

    [SerializeField]
    private GameObject m_stackObj;

    [SerializeField]
    private Text m_stackLabel;

    [SerializeField]
    private GameObject m_prefabItem;

    public void Set(ItemInventario item)
    {
        m_icon.sprite = item.data.icono;
        m_label.text = item.data.nombre;
        m_prefabItem = item.data.prefab;
        if (item.stackSize <= 1)
        {
            m_stackObj.SetActive(false);
            return;
        }
        m_stackLabel.text = item.stackSize.ToString();
    }

    public void SpawnItem()
    {
        if (m_prefabItem != null)
        {
            Vector3 position = GameObject.FindGameObjectWithTag("Player").transform.position;
            GameObject obj = GameObject.Instantiate(m_prefabItem, position, Quaternion.identity);
            ItemObject item = obj.GetComponent<ItemObject>();
            item.Dejar();
        }
    }
}
