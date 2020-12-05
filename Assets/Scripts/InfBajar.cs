using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfBajar : MonoBehaviour
{
    public Bajar bj;
    private bool Actuar;

    void Start(){
        Actuar = true;
    }

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && Actuar.Equals(true))
        {
            bj.cambiarPosicion();
            Actuar = false;
        }
    }
}
