using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class vidaCamara : MonoBehaviour
{
    public Volume vol;
    private ColorAdjustments ca;
    public GameManager gm;
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        vol = GetComponent<Volume>();
        vol.profile.TryGet(out ca);
    }

    // Update is called once per frame
    void Update()
    {
        if(gm.saludPersonaje == 3)
        {
            ca.saturation.value = 0;
        }
        else if (gm.saludPersonaje == 2)
        {
            ca.saturation.value = -55;
        }
        else if (gm.saludPersonaje == 1)
        {
            ca.saturation.value = -90;
        }
    }
}
