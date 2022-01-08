using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListaCompletado : MonoBehaviour
{

    public Text textoActual;
    public float completo;
    public float calculo;
    public ToggleBoolean toggle1;
    public ToggleBoolean toggle2;
    public ToggleBoolean toggle3;
    public ToggleBoolean toggle4;
    public ToggleBoolean toggle5;
    public ToggleBoolean toggle6;

    // Update is called once per frame
    void Update()
    {
        completo = toggle1.valor + toggle2.valor + toggle3.valor + toggle4.valor + toggle5.valor + toggle6.valor;
        calculo = Mathf.Round(100 * completo / 6);
        textoActual.text = calculo + "% " + "Completado";
    }
}
