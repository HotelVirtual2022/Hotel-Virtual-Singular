using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoger : MonoBehaviour
{
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Item") && Input.GetKeyDown(KeyCode.E))
        {
            ItemObject item = collision.gameObject.GetComponent<ItemObject>();
            item.Inventariar();
        }
    }
}
