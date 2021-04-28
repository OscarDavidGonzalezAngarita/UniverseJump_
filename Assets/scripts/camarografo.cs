using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camarografo : MonoBehaviour
{
    public Transform jugador;   
    public float velocidad = 0.125f;
    public Vector3 offset;
    void Update()
    {
        Vector3 poscicionDeseada = jugador.transform.position + offset;
        Vector3 suavizado = Vector3.Lerp(transform.position, poscicionDeseada, velocidad);
        transform.position = suavizado;

        transform.LookAt(jugador.position);
    }
    
}
