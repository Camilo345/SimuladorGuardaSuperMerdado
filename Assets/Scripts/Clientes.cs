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


    int ultimoDigito;
    
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
        
        timer -= 1*Time.deltaTime;
    }
 
    public IEnumerator CoroutinaDesactivar()
    {
        yield return new WaitForSeconds(2);
        this.gameObject.SetActive(false);
    }

    public void desactivar()
    {
        StartCoroutine(CoroutinaDesactivar());
    }
}
