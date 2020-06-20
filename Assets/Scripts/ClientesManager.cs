﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClientesManager : MonoBehaviour
{
    public GameObject[] clientes=new GameObject[3];

    public int i=0;
    public int d=0;
    public bool decidir=false;

    public  animatorControl[] ac;
    // Start is called before the first frame update
    void Start()
    {
        d = PlayerPrefs.GetInt("dia");
        clientes[0].GetComponent<Clientes>().puedoMoverme = true;
        clientes[0].SetActive(true);
        Debug.Log( "dia " +d+"cleinte "+i +"Tapabocas " + clientes[i].GetComponent<Clientes>().tapabocas + " Guantes " + clientes[i].GetComponent<Clientes>().guantes);
   
    }

    // Update is called once per frame
    void Update()
    {
      if(i<4)
        decidir = clientes[i].GetComponent<Clientes>().escoger;
    }

    public void avanzarCliente(bool decision)
    {

        clientes[i].GetComponent<Clientes>().animarFse2(decision);
        clientes[i].GetComponent<Clientes>().desactivar();

        i++;
        if (i < clientes.Length)
        {
            clientes[i].GetComponent<Clientes>().puedoMoverme = true;
            clientes[i].GetComponent<Clientes>().timer = 3;
            clientes[i].SetActive(true);
        }
        if (i == 3)
          StartCoroutine(pasarDia());
        else
        Debug.Log("dia " + d + "cliente " + i + "Tapabocas " + clientes[i].GetComponent<Clientes>().tapabocas + " Guantes " + clientes[i].GetComponent<Clientes>().guantes);
    }

    public IEnumerator pasarDia()
    {
        yield return new WaitForSeconds(3);
        d = PlayerPrefs.GetInt("dia");
        SceneManager.LoadScene(8);
     
    }

    
}
