using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recolectable : MonoBehaviour
{

    public bool isPickable = false;
    public GameObject spawn;
    public GameObject text;

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
        if(isPickable && Input.GetKeyDown(KeyCode.F))
        {
            Destroy(gameObject);
            text.SetActive(false);
            spawn.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            text.SetActive(false);
        }
    }
}