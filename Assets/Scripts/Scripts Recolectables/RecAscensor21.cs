using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecAscensor21 : MonoBehaviour
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
            
        }
        

    }
    private void Update()
    {
        if(isPickable && Input.GetKeyDown(KeyCode.E))
        {
            
            text.SetActive(false);
            StartCoroutine(Ascensor());

        }
    }

    IEnumerator Ascensor()
    {
        animator.Play("CerrarPuerta");
        yield return new WaitForSeconds(2);
        animator.Play("BajarAscensor");
        yield return new WaitForSeconds(4);
        animator.Play("AscensorAbajoAP");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            text.SetActive(false);
        }
    }
}