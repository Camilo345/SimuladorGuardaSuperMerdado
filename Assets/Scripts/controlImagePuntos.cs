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
        i = PlayerPrefs.GetInt("puntos");
        if (i == 1)
        {
            ImagePuntos[0].SetActive(true);
        }
        if (i == 2)
        {
            ImagePuntos[0].SetActive(true);
            ImagePuntos[1].SetActive(true);
        }
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
