using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirProgreso : MonoBehaviour
{
    public GameObject objetoOculto;

    public int repeticion;

    public PlayerCommands inventarioCommands;

    private GameObject miniMap;

    public ListaCompletado listaCompletado;

    void Start()
    {
        objetoOculto.SetActive(false);
        miniMap = GameObject.Find("MinimapBorder");
    }
    // Update is called once per frame
    void Update()
    {
        if (repeticion == 0)
        {
            if (inventarioCommands.inventoryEnabled == false)
            {
                if (listaCompletado.completo >= 3)
                {
                    objetoOculto.SetActive(true);
                    repeticion = 1;
                    Time.timeScale = 0;
                    FirstPersonLook.shouldExecuteLook = false;
                    Zoom.shouldExecuteZoom = false;
                    Cursor.visible = true;
                    miniMap.SetActive(false);
                    Cursor.lockState = CursorLockMode.None;
                    AcercarseTrigger.condicional = 1;
                }
            }
        }
        
    }
}
