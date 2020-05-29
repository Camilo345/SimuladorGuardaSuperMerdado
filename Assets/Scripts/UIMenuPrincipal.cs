using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenuPrincipal : MonoBehaviour
{
    public GameObject HandCursor;
    public GameObject AyudaClick;

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

    private void OnCollisionStay(Collision c)
    {
        if (c.gameObject.tag==("btJugar"))
        {
            botonJugar();
        }
     }

}
