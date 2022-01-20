using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactuar : MonoBehaviour
{
    //public ItemInventario itemReferencia;

    void OnCollisionStay(Collision collision)
    {
        if(collision.tag.equals("item") && Input.getKeyDown(KeyCode.e))
        {
            SistemaInventario.current.Add(Collision.GameObject);
            //Destroy(collision);
            //Debug.Log(collision.name);
        }
    }
}
