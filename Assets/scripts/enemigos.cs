using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigos : MonoBehaviour
{
    public apuntar enLamira;
    public GameObject eneemy;
    public GameManager gm;
    private int daño = -1;
    public GameObject porDefecto;
    private void Start()
    {
        eneemy = gameObject;
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        enLamira = GameObject.Find("Astronauta_").GetComponentInChildren<apuntar>();
        porDefecto = GameObject.Find("por defecto");
        
    }
    private void OnMouseDown()
    {
        enLamira.objetivoActual = eneemy;
    }
    private void Update()
    {
        if (enLamira.objetivoActual == null)
        {
            enLamira.objetivoActual = porDefecto;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gm.vida(daño);
        }

    }
}
