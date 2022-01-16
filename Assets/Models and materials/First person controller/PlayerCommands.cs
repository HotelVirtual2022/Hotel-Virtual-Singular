using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCommands : MonoBehaviour
{

    public bool inventoryEnabled;
    public GameObject inventory;
    public GameObject InventarioPrincipal;
    public GameObject miniMap;

    public GameObject minimenu;
    public GameObject menuPantallas;

    public GameObject map;
    public bool mapEnabled;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryEnabled = !inventoryEnabled;
        }

        if (inventoryEnabled == true)
        {
            inventory.SetActive(true);
            Time.timeScale = 0;
            FirstPersonLook.shouldExecuteLook = false;
            Zoom.shouldExecuteZoom = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            miniMap.SetActive(false);
            minimenu.SetActive(true);
        }
        else
        {
            inventory.SetActive(false);
            minimenu.SetActive(false);
            menuPantallas.SetActive(false);
            InventarioPrincipal.SetActive(true);

        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            mapEnabled = !mapEnabled;
        }

        if (mapEnabled == true)
        {
            map.SetActive(true);
            Time.timeScale = 0;
            FirstPersonLook.shouldExecuteLook = false;
            Zoom.shouldExecuteZoom = false;
            MapMovement.shouldExecuteMap = true;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            miniMap.SetActive(false);
        }
        else
        {
            map.SetActive(false);
            MapMovement.shouldExecuteMap = false;
        }


        if (AcercarseTrigger.condicional == 0)
        {
            if (inventoryEnabled == false && mapEnabled == false)
            {
                Time.timeScale = 1;
                FirstPersonLook.shouldExecuteLook = true;
                Cursor.visible = false;
                Zoom.shouldExecuteZoom = true;
                miniMap.SetActive(true);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
}
