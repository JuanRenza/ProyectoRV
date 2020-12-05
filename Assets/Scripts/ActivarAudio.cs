using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarAudio : MonoBehaviour
{

    public AudioSource Audio;
    public AudioClip clips;
    public bool Empezar;
    // Start is called before the first frame update
    void Start()
    {   
            Audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(Empezar == true)
        {
            Audio.clip = clips;
            Audio.Play();
        }
    }
}
