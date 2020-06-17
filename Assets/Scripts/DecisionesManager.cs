using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DecisionesManager : MonoBehaviour
{
    public GameObject ClientesMan;
    public GameObject puntosScrip;
    public ClientesManager cm;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) && cm.decidir==true)
        {
            botonDecision(true,true);
        }

        if (Input.GetKeyDown(KeyCode.A) && cm.decidir == true)
        {
            botonDecision(false,false);            
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene(1);
        }
    }


    public void botonDecision(bool decision,bool avanzar)
    {
        ClientesMan.GetComponent<ClientesManager>().avanzarCliente(decision);
        puntosScrip.GetComponent<PuntosScript>().VerificarCliente(avanzar);
    }


}
