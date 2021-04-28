using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ataqueEnemigos : MonoBehaviour
{
    public int vidaEnemigo;
    public Transform guarida;
    private NavMeshAgent navene;
    private Transform jugador;
    private Vector3 enemig;
    public LayerMask jug;
    public bool caza;
    private float radio = 6;
    void Start()
    {
        navene = GetComponent<NavMeshAgent>();
        enemig = transform.position;
        jugador = GameObject.Find("Astronauta_").GetComponent<Transform>();
        jug = LayerMask.GetMask("Player");
        caza = false;
        vidaEnemigo = 3;
    }
    void Update()
    {
        detectar();
        if (caza == true)
        {
            navene.SetDestination(jugador.position);
        }
        else
        {
            navene.SetDestination(guarida.position);
        }
        vida();
    }
    void detectar()
    {
        Collider[] hitColliders = Physics.OverlapSphere(enemig, radio, jug, QueryTriggerInteraction.Collide);

        if (hitColliders.Length >= 1)
        {
            caza = true;
        }
        else if (hitColliders.Length <= 1)
        {
            caza = false;
        }

    }
    public void vida()
    {
        if (vidaEnemigo == 0)
        {
            Destroy(gameObject);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala"))
        {
            vidaEnemigo -= 1;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(enemig, radio);
    }
}
