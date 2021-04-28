using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public int saludPersonaje;
    public bool gasolina;
    public bool nivel1;
    public bool nivel2;
    public bool nivel3;
    private void Start()
    {
        gasolina = false;
        saludPersonaje = 3;
        nivel1 = false;
        nivel2 = false;
    }
    public void vida(int pdv)
    {
        saludPersonaje += pdv;
    }
    private void Update()
    {
        muerte();
        nive1_2();
        nivel2_3();
        nivel3_menu();
    }
    void muerte()
    {
        if (saludPersonaje == 0)
        {
            SceneManager.LoadScene("Menu");
        }
    }
    void nive1_2()
    {
        if (gasolina == true && nivel1 == true)
        {
            SceneManager.LoadScene("Nivel2");
            nivel1 = false;
        }
    }
    void nivel2_3()
    {
        if (gasolina == true && nivel2 == true)
        {
            SceneManager.LoadScene("Nivel3");
            nivel2 = false;
        }
    }
    void nivel3_menu()
    {
        if (gasolina == true && nivel3 == true)
        {
            SceneManager.LoadScene("Menu");
            nivel3 = false;
        }
    }
}

