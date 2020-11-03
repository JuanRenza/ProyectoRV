using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amplificar : MonoBehaviour
{

    public AudioSource Audio;
    private float tasa, audioInicial;
    public bool Empezar;

    // Start is called before the first frame update
    void Start()
    {
        audioInicial = Audio.volume;
        Empezar = false;
        tasa = 0.001f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Empezar == true)
        {
            if(Audio.volume < 1.0f)
            {
                Audio.volume += tasa;
            }
            
        }
        else
        {
            if(Audio.volume > audioInicial)
            {
                Audio.volume -= tasa;
            }
        }
    }
}
