using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlImagePuntos : MonoBehaviour
{
    public GameObject[] ImagePuntos;

    public int i=0;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      

    }
    public void activarImage()
    {  
        StartCoroutine(desactivar());
    }
    public IEnumerator desactivar()
    {
        yield return new WaitForSeconds(1);
        i = PlayerPrefs.GetInt("puntos");
        Debug.Log("i:" + i);
        ImagePuntos[i-1].SetActive(true);
    }
}
