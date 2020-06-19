﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorControl : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void fase1()
    {
        anim.SetBool("fase1", true);
        anim.SetBool("fase2", false);
    }

    public void fase2()
    {
        anim.SetBool("fase2", true);
        anim.SetBool("fase1", false);
        anim.SetBool("fase2B", false);

        StartCoroutine(fase3());
    }

    public void fase2B()
    {
        anim.SetBool("fase2B", true);
        anim.SetBool("fase1", false);
        anim.SetBool("fase2", false);
        StartCoroutine(fase3());
    }
    public IEnumerator fase3()
    {
        yield return new WaitForSeconds(1);
        anim.SetBool("fase2", true);
        anim.SetBool("fase1", true);
        anim.SetBool("fase2B", false);
    }

    public IEnumerator fase3B()
    {
        yield return new WaitForSeconds(1);
        anim.SetBool("fase2", false);
        anim.SetBool("fase1", true);
        anim.SetBool("fase2B", true);
    }

}
