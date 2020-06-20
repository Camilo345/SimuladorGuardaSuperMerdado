using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clientes : MonoBehaviour
{

    public string nombre;
    public string apellido;
    public int Cedula;
    public bool tapabocas;
    public bool guantes;
    public float velocidad;
    public GameObject[] targets;
    public bool puedoMoverme = false;
    public int i = 1;
    public float timer = 2;
    public bool escoger = false;
   public animatorControl ac;

    int ultimoDigito;
    bool empezar = true;
    
    // Start is called before the first frame update
    void Start()
    {
        ultimoDigito = Cedula % 10;
        this.transform.position = targets[0].transform.position;
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (puedoMoverme && timer < 0)
            this.transform.position = Vector3.MoveTowards(transform.position, targets[i].transform.position, velocidad);

        if (transform.position == targets[1].transform.position)
        {
            escoger = true;
            if (empezar)
            {
               ac.fase1();
                empezar = false;
            }
        }
        else
        {
            escoger = false;
        }
            
        
        timer -= 1*Time.deltaTime;
    }
 
    public IEnumerator CoroutinaDesactivar()
    {
        yield return new WaitForSeconds(6);
        this.gameObject.SetActive(false);
        puedoMoverme = false;
    }

    public void desactivar()
    {
        StartCoroutine(CoroutinaDesactivar());
    }

    public void cambierMoverme()
    {
        StartCoroutine(Moverme());
        puedoMoverme=true;
    }

    public IEnumerator Moverme()
    {
        yield return new WaitForSeconds(1);
        puedoMoverme = true;
    }
    public void animarFse2(bool dec)
    {
        if (dec)
        {
           ac.fase2();   
        }
        else
        {
           ac.fase2B();
        }
        StartCoroutine(animarF2(dec));
    }
    public IEnumerator animarF2(bool deci)
    {
        yield return new WaitForSeconds(1.1f);
        if (deci)
            i++;
        else
            i--;
     
    }


}
