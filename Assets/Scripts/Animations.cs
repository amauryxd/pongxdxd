using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Animations : MonoBehaviour
{
    Animator animacion;
    [SerializeField] bool isPaddle1;
    float movement;

    // Start is called before the first frame update
    void Start()
    {
        animacion = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPaddle1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }
        Debug.Log(movement);
        
        if (movement < -0.1)
        {
            animacion.SetBool("RunU",true);
        }
        if (movement > 0.1)
        {
            animacion.SetBool("RunD", true);
        }
        if (movement == 0)
        {
            animacion.SetBool("RunU", false);
            animacion.SetBool("RunD", false);
        }
       
    }
}
