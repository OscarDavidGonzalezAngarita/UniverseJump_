using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gasolina : MonoBehaviour
{
    private GameManager gm;
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            gm.gasolina = true;
            gm.nivel1 = true;
            Destroy(gameObject);
            
        }
    }
}
