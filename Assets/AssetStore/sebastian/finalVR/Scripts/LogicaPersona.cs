using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPersona : MonoBehaviour

{

    public float velocidad = 5.0f;
    

    private Animator anim;
    public float  y;
    // Start is called before the first frame update
    void Start()
    {
        this.anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        y = y + 0.1f;
        
        transform.Translate(0, 0, y * Time.deltaTime * velocidad);

        Debug.Log(Time.deltaTime);

        
        anim.SetFloat("VelY", y);

        if (y == 1000)
        {

           
            y = 0;

        }

    }
}
