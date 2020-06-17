using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClientesManager : MonoBehaviour
{
    public GameObject[] clientes;
    public int i=0;
    public int d=0;
    public bool decidir=false;
    
  
    // Start is called before the first frame update
    void Start()
    {
        clientes[0].GetComponent<Clientes>().puedoMoverme = true;
        clientes[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        d = PlayerPrefs.GetInt("dia");
        Debug.Log("d:"+d);
        decidir = clientes[i].GetComponent<Clientes>().escoger;
    }

    public void avanzarCliente(bool decision)
    {

        if (decision && i < clientes.Length) 
            clientes[i].GetComponent<Clientes>().i++;
        else
            clientes[i].GetComponent<Clientes>().i--;

        clientes[i].GetComponent<Clientes>().desactivar();
        i++;
        if (i < clientes.Length)
        {
            clientes[i].GetComponent<Clientes>().puedoMoverme = true;
            clientes[i].GetComponent<Clientes>().timer = 2;
            clientes[i].SetActive(true);
        }
        if (i == 3)
          StartCoroutine(pasarDia());
    }

    public IEnumerator pasarDia()
    {
        yield return new WaitForSeconds(3);
        d = PlayerPrefs.GetInt("dia");
        d++;
        PlayerPrefs.SetInt("dia", d);
        if (d > 4)
        {
            SceneManager.LoadScene(2);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    
    }
}
