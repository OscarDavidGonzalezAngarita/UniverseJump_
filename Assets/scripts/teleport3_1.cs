using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport3_1 : MonoBehaviour
{
    public Transform destino;
    public Transform jugadorr;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            jugadorr.position = destino.position;

        }
    }
}