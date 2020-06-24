using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DocumentoManager : MonoBehaviour
{
    public Text nombre;
    public Text edad;
    public Text Documento;
  //  public Text guantes;
   // public Text tapabocas;
    public GameObject panel;
    public GameObject clientesManager;

    int i;
    bool escoger=false;
    GameObject[] clientes;
   
    void Start()
    {
        
    }

    void Update()
    {
        i = clientesManager.GetComponent<ClientesManager>().i;
        clientes = clientesManager.GetComponent<ClientesManager>().clientes;
        escoger = clientesManager.GetComponent<ClientesManager>().decidir;
        if (i < clientes.Length && escoger==true)
        {
            nombre.text = clientes[i].GetComponent<Clientes>().nombre;
            edad.text = clientes[i].GetComponent<Clientes>().apellido;
            Documento.text = clientes[i].GetComponent<Clientes>().Cedula.ToString();
            //   tapabocas.text = "Tapabocas "+ clientes[i].GetComponent<Clientes>().tapabocas;
            //   guantes.text = "Guantes " + clientes[i].GetComponent<Clientes>().guantes;

        }
        else
        {
            nombre.text = "";
            edad.text = "";
            Documento.text = "";
        }

    }
}
