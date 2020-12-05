using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bajar : MonoBehaviour
{
 public Transform[] posicion;
 public float transitionSpeed; 
 Transform posicioninicial;
 public int camPos;

 public void Start(){
     posicioninicial = posicion[0];
     camPos = 0;
 }

 public void cambiarPosicion(){
     camPos ++;
     posicioninicial = posicion [camPos];
 }
 

 void LateUpdate () {

  //Lerp position
  transform.position = Vector3.Lerp(transform.position, posicioninicial.position, Time.deltaTime * transitionSpeed);

  Vector3 currentAngle = new Vector3 (
   Mathf.LerpAngle(transform.rotation.eulerAngles.x, posicioninicial.transform.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed),
   Mathf.LerpAngle(transform.rotation.eulerAngles.y, posicioninicial.transform.rotation.eulerAngles.y, Time.deltaTime * transitionSpeed),
   Mathf.LerpAngle(transform.rotation.eulerAngles.z, posicioninicial.transform.rotation.eulerAngles.z, Time.deltaTime * transitionSpeed));

  transform.eulerAngles = currentAngle;

 }
}
