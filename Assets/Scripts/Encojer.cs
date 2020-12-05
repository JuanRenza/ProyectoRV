using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encojer : MonoBehaviour
{

    public GameObject Objeto;
    private float tasa;
    public bool Empezar;
    private Vector3 escalaObjeto, cambioEscala;
    // Start is called before the first frame update
    void Start()
    {
        escalaObjeto = Objeto.transform.localScale;
        cambioEscala = Objeto.transform.localScale;
        Empezar = false;
        tasa = 0.0001f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Empezar == true)
        {
            if(cambioEscala.x > 0.0f && cambioEscala.y > 0.0f && cambioEscala.z > 0.0f)
            {
                cambioEscala.x = cambioEscala.x - tasa;
                cambioEscala.y = cambioEscala.y - tasa;
                cambioEscala.z = cambioEscala.z - tasa;
                Objeto.transform.localScale = cambioEscala;
            }
        }
        else
        {
            if(cambioEscala.x < escalaObjeto.x)
            {
                cambioEscala.x = cambioEscala.x + tasa;
                cambioEscala.y = cambioEscala.y + tasa;
                cambioEscala.z = cambioEscala.z + tasa;
                Objeto.transform.localScale = cambioEscala;
            }
        }
    }
}
