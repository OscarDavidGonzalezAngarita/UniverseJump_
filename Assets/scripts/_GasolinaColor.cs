using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _GasolinaColor : MonoBehaviour
{    
    public Sprite Colores, BlancoYNegro;
    public SpriteRenderer ColorActual;
    public GameManager gm;
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        ColorActual = GetComponent<SpriteRenderer>();
        Colores = Resources.Load<Sprite>("bidon_color");
        BlancoYNegro = Resources.Load<Sprite>("bidon_BN");
    }
    private void Update()
    {
        cambioDeColor();
    }
    void cambioDeColor()
    {
        if(gm.gasolina == false)
        {
            ColorActual.sprite = BlancoYNegro;
        }
        else
        {
            ColorActual.sprite = Colores;
        }
    }
}
