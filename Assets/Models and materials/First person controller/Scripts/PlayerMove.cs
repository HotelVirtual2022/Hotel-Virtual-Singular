using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Animator animator;

    private float x, y;


    void Update()
    {
    x = Input.GetAxis("Horizontal");
    y = Input.GetAxis("Vertical");


    animator.SetFloat("VelX", x);
    animator.SetFloat("VelY", y);   

    }
}
