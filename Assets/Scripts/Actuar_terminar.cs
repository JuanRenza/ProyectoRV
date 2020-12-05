using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Actuar_terminar : MonoBehaviour
{

    public Encojer e;
    public Oscurecer o;
    public Amplificar a;
    public FadeIn fade;

    private void OnTriggerEnter(Collider other)
    {
            if (other.tag == "Player")
            {
                  o.Empezar = true;
                  e.Empezar = true;
                  a.Empezar = true;
            }
            StartCoroutine(Terminar());
    }
    

        IEnumerator Terminar()
    {
        yield return new WaitForSeconds(15);
        fade.fadeout();
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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
