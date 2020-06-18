using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuDia : MonoBehaviour
{
    public string[] diaSemana;
    public Text diaActual;
    public Text diaSiguiente;
    int d;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(pasarDIa());
        d = PlayerPrefs.GetInt("dia");
        diaActual.text = diaSemana[d];
        diaSiguiente.text = diaSemana[d+1];
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator pasarDIa()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(d + 2);
    }
}
