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
        //Asigna informaci�n del item al slot
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
            //Busca punto spawn
            GameObject player =GameObject.FindGameObjectWithTag("Player");
            //Define la posisi�n en la que se generar� el item
            Vector3 position = player.transform.position + (player.transform.up * 2f) + (player.transform.forward * 2f);
            //Asigna la rotaci�n del item respecto al punto de spawn
            Quaternion playerRotation = player.transform.rotation;
            //Genera el item
            GameObject obj = GameObject.Instantiate(m_prefabItem, position, playerRotation);
            ItemObject item = obj.GetComponent<ItemObject>();
            item.Dejar();
        }
    }
}
