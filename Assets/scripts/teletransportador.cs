using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teletransportador : MonoBehaviour
{
    public GameManager gm;
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gm.activar = true;
        }
    }
}
