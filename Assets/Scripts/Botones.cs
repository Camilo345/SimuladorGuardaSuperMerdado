using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botones : MonoBehaviour
{
    public GameObject HandCursor;
    public GameObject AyudaClick;

    static int puntos=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }


    public void botonJugar()
    {
        SceneManager.LoadScene(1);
    }
    public void botonSalir()
    {
        Application.Quit();
    }

    public void botonReintentar()
    {
        SceneManager.LoadScene(1);
    }
    public void botonInicio()
    {
        SceneManager.LoadScene(0);
    }

    private void OnCollisionStay(Collision c)
    {
        if (c.gameObject.tag==("btJugar"))
        {
            botonJugar();
        }
     }
    public void CambiarPuntos(int puntaje)
    {
        puntos = puntaje;
    }
    public int retornarPuntos()
    {
        int p = puntos;
        return p;
    }

}
