using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taretsClieb : MonoBehaviour
{
    public GameObject[] targets;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject[] darTar()
    {
        GameObject[] list = new GameObject[3];
        for(int i = 0; i < targets.Length; i++)
        {
            list[i] = targets[i];
        }

        return list;
    }
}
