using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amplificar : MonoBehaviour
{

    public AudioSource Audio;
    private float tasa1, tasa2, audioInicial;
    public bool Empezar;

    // Start is called before the first frame update
    void Start()
    {
        audioInicial = Audio.volume;
        Audio.Play();
        Empezar = false;
        tasa2 = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Empezar == true)
        {
            if(Audio.volume < 1.0f)
            {
                Audio.volume = 0.99f;
            }
            
        }
        else
        {
            if(Audio.volume > audioInicial)
            {
                Audio.volume -= tasa2;
            }
        }
    }
}
