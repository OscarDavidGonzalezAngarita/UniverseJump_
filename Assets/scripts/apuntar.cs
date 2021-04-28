using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apuntar : MonoBehaviour
{
    public GameObject objetivoActual;
    private void Start()
    {

    }
    private void Update()
    {
        transform.LookAt(objetivoActual.transform);
    }
}
