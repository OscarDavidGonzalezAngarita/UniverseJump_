using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class movimiento : MonoBehaviour
{
    public LayerMask click_en;
    public LayerMask click_enemigo;
    private NavMeshAgent agente;
    public Rigidbody bala;
    public Transform pistola;
    private float velocidadBala = 10;
    private float puedeDisparar = 0.0f;
    private float LosDisparos = 0.1f;
    void Start()
    {
        pistola = GameObject.Find("pistola").GetComponent<Transform>();
        agente = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(myRay, out hitInfo, maxDistance: 100, click_enemigo))
            {
                if (Time.time > puedeDisparar)
                {
                    Rigidbody
                  shellInstance =
                  Instantiate(bala, pistola.position, pistola.rotation) as Rigidbody;
                    shellInstance.velocity = velocidadBala * pistola.forward;
                }
                puedeDisparar = Time.time + LosDisparos;
            }
            else if (Physics.Raycast(myRay, out hitInfo, 100, click_en))
            {
                agente.SetDestination(hitInfo.point);
            }
        }
    }
}