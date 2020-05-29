using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DecisionesManager : MonoBehaviour
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
            botonDecision(true);
            puntosScrip.GetComponent<PuntosScript>().VerificarCliente(true);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            botonDecision(false);
            puntosScrip.GetComponent<PuntosScript>().VerificarCliente(false);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene(1);
        }
    }


    public void botonDecision(bool decision)
    {
        ClientesMan.GetComponent<ClientesManager>().avanzarCliente(decision);
    }


}
