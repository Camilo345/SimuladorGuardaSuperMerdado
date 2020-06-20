using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorControl : MonoBehaviour
{
    private Animator anim;
    public Animator anim2;
  
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
        //  anim.SetBool("fase1",true);
        anim2.SetTrigger("faseC1");
        StartCoroutine(cambiarRot());
    }

    public void fase2()
    {
        //  transform.rotation = Quaternion.Euler(0, -90, 0);
        //    anim.SetTrigger("fase2a");
        //  StartCoroutine(fase3());
        anim2.SetTrigger("faseC2a");
        anim.SetTrigger("fase2");
       
    }

    public void fase2B()
    {
        //anim.SetTrigger("fase2b");
        //StartCoroutine(fase3B());  
        anim2.SetTrigger("faseC2b");
        anim.SetTrigger("fase2");
      
    }
    public IEnumerator fase3()
    {
        yield return new WaitForSeconds(1f);       
        anim.SetTrigger("fase3a");
    }

    public IEnumerator fase3B()
    {     
        yield return new WaitForSeconds(1f);
        transform.rotation = Quaternion.Euler(0, 90, 0);
        anim.SetTrigger("fase3b");  
    }

    public IEnumerator cambiarRot()
    {
        yield return new WaitForSeconds(0.95f);
        anim.SetTrigger("fase1");
        //transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
