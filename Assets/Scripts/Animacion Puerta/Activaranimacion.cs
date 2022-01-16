using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activaranimacion : MonoBehaviour
{
    public GameObject Objeto;
    public AnimationClip Animacion;
    private Animation Animaccionaccion;
    // Start is called before the first frame update
    void Start()
    {
        Animaccionaccion = Objeto.AddComponent<Animation>();
        Animaccionaccion.AddClip(Animacion, "AnimacionPrueba");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
