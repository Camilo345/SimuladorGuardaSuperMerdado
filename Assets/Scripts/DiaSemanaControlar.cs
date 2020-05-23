using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiaSemanaControlar : MonoBehaviour
{
   
    public int numero1;
    public int numero2;
    public GameObject[] CartelesMaerial;
    public GameObject cartel;
    // Start is called before the first frame update
    void Start()
    {
        definirDia();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void definirDia()
    {
        GameObject objeto;
        int numero = Random.Range(0, 5);     

        if (numero == 0)
        {
            numero1 = 0;
            numero2 = 1;
            objeto=  Instantiate(CartelesMaerial[0]);
            objeto.transform.position = cartel.transform.position;
         }
        if (numero == 1)
        {
            numero1 = 2;
            numero2 = 3;
            objeto = Instantiate(CartelesMaerial[1]);
            objeto.transform.position = cartel.transform.position;
        }
        if (numero == 2)
        {
            numero1 = 4;
            numero2 = 5;
            objeto = Instantiate(CartelesMaerial[2]);
            objeto.transform.position = cartel.transform.position;
        }
        if (numero == 3)
        {
           numero1 = 6;
           numero2 = 7;
            objeto = Instantiate(CartelesMaerial[3]);
            objeto.transform.position = cartel.transform.position;
        }
        if (numero == 4)
        {
            numero1 = 8;
            numero2 = 9;
            objeto = Instantiate(CartelesMaerial[4]);
            objeto.transform.position = cartel.transform.position;
        }
    }
}
