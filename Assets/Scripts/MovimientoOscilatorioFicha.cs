using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoOscilatorioFicha : MonoBehaviour
{
    public float velocidad = 0.02f;
    //public float limiteInferior = 0.0f;
    //public float limiteSuperior = 5.0f;
    //public Vector3 posicionInicial = new Vector3(0, 0, 0);
    public Vector3[] targets;
    int i=1;

    bool aumentar = true;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = targets[0];
    }

    // Update is called once per frame
    void Update()
    {

        this.transform.position = Vector3.MoveTowards(transform.position, targets[i], velocidad);

    }

    public void cambiarTarget()
    {
        i++;
    }
}
