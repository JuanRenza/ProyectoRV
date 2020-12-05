using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecAscensor2 : MonoBehaviour
{
    public bool isPickable = false;
    public GameObject spawn;
    public GameObject text;
    public Animator animator;

    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            //other.GetComponentInParent<gestorPuntos>().puntos += 1;
            text.SetActive(true);
            isPickable = true;
            animator.Play("AbrirPuerta");
            
        }
        

    }
    private void Update()
    {
  
    }
}