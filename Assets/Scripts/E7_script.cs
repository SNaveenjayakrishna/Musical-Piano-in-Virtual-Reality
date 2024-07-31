using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E7_script : MonoBehaviour
{
      public AudioSource sound_e7;
    public GameObject key_e7;
     

     void Start(){

   }
   void Update(){

   }


void OnCollisionEnter(Collision col){

            if((key_e7.GetComponent<Renderer>().material.color == Color.red)){
      
           
           
 
  sound_e7.Play();
  key_e7.transform.localPosition = new Vector3(-0.906f,2.198f,-0.058f);
 
            }
      
}void OnCollisionExit(Collision col){
  
  key_e7.GetComponent<Renderer>().material.color = Color.white;

    key_e7.transform.localPosition = new Vector3(-0.906f,2.51f,-0.058f);

}
}
