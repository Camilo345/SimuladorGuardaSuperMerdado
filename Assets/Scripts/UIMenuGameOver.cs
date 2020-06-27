using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMenuGameOver : MonoBehaviour
{
    public Text puntaje;
    public GameObject botones;
    // Start is called before the first frame update
    void Start()
    {
        int p = 3-PlayerPrefs.GetInt("puntos");
        PlayerPrefs.SetInt("puntos", 0);
        puntaje.text =(p * 100)+"";
    }

    // Update is called once per frame
    void Update()
    {
       
    }

}
