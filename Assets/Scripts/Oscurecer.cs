using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscurecer : MonoBehaviour
{

    public Light luz;
    private Light cambioLuz;
    private float tasa, luzInicial;
    public bool Empezar;

    // Start is called before the first frame update
    void Start()
    {
        luzInicial = luz.intensity;
        Debug.Log(luzInicial);
        cambioLuz = luz;
        Empezar = false;
        tasa = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Empezar == true)
        {
            if(cambioLuz.intensity > 0.0f)
            {
                cambioLuz.intensity = cambioLuz.intensity - tasa;
                luz.intensity = cambioLuz.intensity;
                Debug.Log(cambioLuz.intensity);
            }
            
        }
        else
        {
            if(cambioLuz.intensity < luzInicial)
            {
                cambioLuz.intensity = cambioLuz.intensity + tasa;
                luz.intensity = cambioLuz.intensity;
            }
        }
    }
}

