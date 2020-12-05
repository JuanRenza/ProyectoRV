using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actuar : MonoBehaviour
{

    public Encojer e;
    public Oscurecer o;
    public Amplificar a;

    private void OnTriggerEnter(Collider other)
    {
            if (other.tag == "Player")
            {
              try{
                  o.Empezar = true;
              }catch{
                        try{
                            e.Empezar = true;
                        }catch{
                            a.Empezar = true;
                        }
                }
            }
    }

        private void OnTriggerExit(Collider other)
    {
            if (other.tag == "Player")
            {
              try{
                  o.Empezar = false;
              }catch{
                        try{
                            e.Empezar = false;
                        }catch{
                            a.Empezar = false;
                        }
                }
            }   
    }

    
}
