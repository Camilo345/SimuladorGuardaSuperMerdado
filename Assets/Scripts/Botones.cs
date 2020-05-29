using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    public GameObject ClientesMan;
    public GameObject puntosScrip;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            ClientesMan.GetComponent<ClientesManager>().avanzarCliente(true);
            puntosScrip.GetComponent<PuntosScript>().VerificarCliente(true);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            ClientesMan.GetComponent<ClientesManager>().avanzarCliente(false);
           puntosScrip.GetComponent<PuntosScript>().VerificarCliente(false);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void botonAceptar()
    {
        ClientesMan.GetComponent<ClientesManager>().avanzarCliente(true);
    }

    public void botonRechazar()
    {
        ClientesMan.GetComponent<ClientesManager>().avanzarCliente(false);
    }

}
