using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfAudio : MonoBehaviour
{
public ActivarAudio a;

    private void OnTriggerEnter(Collider other)
    {
            if (other.tag == "Player")
            {

                a.Empezar = true;
            }
    }
}
