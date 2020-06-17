﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botones : MonoBehaviour
{

   public int puntos=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntos = PlayerPrefs.GetInt("puntos");
        if (puntos == 3)
        {
            StartCoroutine(gameOver());
        }
    }


    public void botonJugar()
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("puntos", 0);
    }
    public void botonSalir()
    {
        Application.Quit();
    }

    public void botonReintentar()
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("puntos", 0);
    }
    public void botonInicio()
    {
        SceneManager.LoadScene(0);
        PlayerPrefs.SetInt("puntos", 0);
    }

    public void CambiarPuntos(int puntaje)
    {
        puntos = puntaje;
    }
    public int retornarPuntos()
    {
        int p = PlayerPrefs.GetInt("puntos");
        p = puntos;
        return p;
    }

    public IEnumerator gameOver()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(7);
        PlayerPrefs.SetInt("puntos", 0);
    }
}
