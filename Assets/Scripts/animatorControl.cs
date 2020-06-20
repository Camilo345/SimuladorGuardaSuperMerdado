using System.Collections;
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
        anim.SetTrigger("fase1");
       StartCoroutine(cambiarRot());
    }

    public void fase2()
    {
        transform.rotation = Quaternion.Euler(0, -90, 0);
        anim.SetTrigger("fase2a");
        StartCoroutine(fase3());
    }

    public void fase2B()
    {
       
        anim.SetTrigger("fase2b");

        StartCoroutine(fase3B());
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
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
