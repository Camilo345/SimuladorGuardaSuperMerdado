using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class instruccionesScript : MonoBehaviour
{
 

    float z = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(empezar());
    }

    // Update is called once per frame
    void Update()
    {
        z += 50 * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, 0, z);
    }
    public IEnumerator empezar()
    {
        yield return new WaitForSeconds(Random.Range(15, 20));
        SceneManager.LoadScene(8);
    }
}
