using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiaSemanaControlar : MonoBehaviour
{
    public Text diaSemana;
    public Text numeros;
    public int numero1;
    public int numero2;
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

        int numero = Random.Range(0, 5);
        

        if (numero == 0)
        {
            numero1 = 0;
            numero2 = 1;
            diaSemana.text = "Lunes";
        }
        if (numero == 1)
        {
            numero1 = 2;
            numero2 = 3;
            diaSemana.text = "Martes";
        }
        if (numero == 2)
        {
            numero1 = 4;
            numero2 = 5;
            diaSemana.text = "Miercoles";
        }
        if (numero == 3)
        {
            numero1 = 6;
            numero2 = 7;
            diaSemana.text = "Jueves";
        }
        if (numero == 4)
        {
            numero1 = 8;
            numero2 = 9;
            diaSemana.text = "Viernes";
        }
        numeros.text = numero1 + " y " + numero2;
    }
}
