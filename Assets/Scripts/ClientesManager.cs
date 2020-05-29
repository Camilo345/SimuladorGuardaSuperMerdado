using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientesManager : MonoBehaviour
{
    public GameObject[] clientes;
    public int i=0;

  
    // Start is called before the first frame update
    void Start()
    {
        clientes[0].GetComponent<Clientes>().puedoMoverme = true;
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void avanzarCliente(bool decision)
    {
       

        if (decision && i < clientes.Length) 
            clientes[i].GetComponent<Clientes>().i++;
        else
            clientes[i].GetComponent<Clientes>().i--;

        i++;
        if (i < clientes.Length)
        {
            clientes[i].GetComponent<Clientes>().puedoMoverme = true;
            clientes[i].GetComponent<Clientes>().timer = 2;
        }
      
    }

}
