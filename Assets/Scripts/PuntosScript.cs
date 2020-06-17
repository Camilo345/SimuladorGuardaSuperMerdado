using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PuntosScript : MonoBehaviour
{

    public Text errores;
    public GameObject diaSemanaController;
    public GameObject clientesManager;
    public int ConteoErrores=0;
    public GameObject botones;

    int i;
     public float timerGameOver = 0;
    GameObject[] clientes;

    // Start is called before the first frame update
    void Start()
    {
      clientes = clientesManager.GetComponent<ClientesManager>().clientes;
      ConteoErrores = PlayerPrefs.GetInt("puntos");
    }

    // Update is called once per frame
    void Update()
    {
        i = clientesManager.GetComponent<ClientesManager>().i;
       
        errores.text = ConteoErrores + "";
        if (timerGameOver > 2 && timerGameOver<2.5)
        {
            SceneManager.LoadScene(6);
        }
        timerGameOver -= 1 * Time.deltaTime;
    }

    public void VerificarCliente(bool decision)
    {
        bool tapabocas=clientes[i].GetComponent<Clientes>().tapabocas;
        bool guantes= clientes[i].GetComponent<Clientes>().guantes;
        int digitoCedula= (clientes[i].GetComponent<Clientes>().Cedula)%10;
        int numero1 = diaSemanaController.GetComponent<DiaSemanaControlar>().numero1;
        int numero2 = diaSemanaController.GetComponent<DiaSemanaControlar>().numero2;
      

        if ((tapabocas == false || guantes == false||(digitoCedula!=numero1&&digitoCedula!=numero2)) && decision == true)
        {
            sumarError();
        }
        else if (tapabocas == true && guantes == true&&(digitoCedula==numero1||digitoCedula==numero2) && decision == false)
        {
            sumarError();
        }
    }
    public void sumarError()
    {
        ConteoErrores ++;
        PlayerPrefs.SetInt("puntos", ConteoErrores);
    }
}
