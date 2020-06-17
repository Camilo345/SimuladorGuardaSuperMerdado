using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escogerClientes : MonoBehaviour
{
    public GameObject[] todosClientes;
    public GameObject[] clientes= new GameObject[3];

    GameObject[] list;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject[] escogerCli(int d)
    {
    
       

        if (d == 0)
        {
           clientes[0]  = Instantiate(todosClientes[0]);
           clientes[1]  = Instantiate(todosClientes[1]);
           clientes[2]  = Instantiate(todosClientes[2]);
        }
        if (d == 1)
        {
            clientes[0]  = Instantiate(todosClientes[3]);
            clientes[1]  = Instantiate(todosClientes[4]);
            clientes[2]  = Instantiate(todosClientes[5]);
        }
        if (d == 2)
        {
            clientes[0]  = Instantiate(todosClientes[6]);
            clientes[1]  = Instantiate(todosClientes[7]);
            clientes[2]  = Instantiate(todosClientes[8]);
        }
        if (d == 3)
        {
            clientes[0]  = Instantiate(todosClientes[9]);
            clientes[1]  = Instantiate(todosClientes[10]);
            clientes[2]  = Instantiate(todosClientes[11]);
        }
        if (d == 4)
        {
            clientes[0]  = Instantiate(todosClientes[12]);
            clientes[1]  = Instantiate(todosClientes[13]);
            clientes[2]  = Instantiate(todosClientes[14]);
        }
  
        return clientes;
    }
}
