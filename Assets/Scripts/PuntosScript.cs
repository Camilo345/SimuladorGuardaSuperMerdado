using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntosScript : MonoBehaviour
{

    public Text errores;
    public GameObject diaSemanaController;
    public GameObject clientesManager;
    public int ConteoErrores=0;

    int i;
    GameObject[] clientes;

    // Start is called before the first frame update
    void Start()
    {
      clientes = clientesManager.GetComponent<ClientesManager>().clientes;
    }

    // Update is called once per frame
    void Update()
    {
        i = clientesManager.GetComponent<ClientesManager>().i;
       
        errores.text = ConteoErrores + "";
    }

    public void VerificarCliente(bool decision)
    {
        bool tapabocas=clientes[i].GetComponent<Clientes>().tapabocas;
        bool guantes= clientes[i].GetComponent<Clientes>().guantes;
        int digitoCedula= (clientes[i].GetComponent<Clientes>().Cedula)%10;
        int numero1 = diaSemanaController.GetComponent<DiaSemanaControlar>().numero1;
        int numero2 = diaSemanaController.GetComponent<DiaSemanaControlar>().numero2;
        Debug.Log(tapabocas + " " + guantes);

        if ((tapabocas == false || guantes == false||(digitoCedula!=numero1&&digitoCedula!=numero2)) && decision == true)
        {
            ConteoErrores++;
        }
        if (tapabocas == true && guantes == true&&(digitoCedula==numero1||digitoCedula==numero2) && decision == false)
        {
            ConteoErrores++;
        }
    }
}
