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

    public  int dia = 0;
    // Start is called before the first frame update
    void Start()
    {
        dia = PlayerPrefs.GetInt("dia");
        if (dia > 4)
            dia = 0;

        PlayerPrefs.SetInt("dia",dia);
        definirDia();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void definirDia()
    {
        GameObject objeto;

        if (dia == 0)
        {
            numero1 = 1;
            numero2 = 2;
            objeto=  Instantiate(CartelesMaerial[0]);
            objeto.transform.position = cartel.transform.position;
         }
        if (dia == 1)
        {
            numero1 = 3;
            numero2 = 4;
            objeto = Instantiate(CartelesMaerial[1]);
            objeto.transform.position = cartel.transform.position;
        }
        if (dia == 2)
        {
            numero1 = 5;
            numero2 = 6;
            objeto = Instantiate(CartelesMaerial[2]);
            objeto.transform.position = cartel.transform.position;
        }
        if (dia == 3)
        {
           numero1 = 7;
           numero2 = 8;
            objeto = Instantiate(CartelesMaerial[3]);
            objeto.transform.position = cartel.transform.position;
        }
        if (dia == 4)
        {
            numero1 = 9;
            numero2 = 0;
            objeto = Instantiate(CartelesMaerial[4]);
            objeto.transform.position = cartel.transform.position;
        }
    }
}
