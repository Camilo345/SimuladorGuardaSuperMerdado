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
        
    }

    // Update is called once per frame
    void Update()
    {
        puntaje.text = botones.GetComponent<botones>().retornarPuntos()+"";
    }

}
