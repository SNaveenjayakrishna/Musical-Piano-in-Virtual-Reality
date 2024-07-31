using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D7_script : MonoBehaviour
{
        public AudioSource sound_d7;
    public GameObject key_d7;
 
  void Start(){

  }
   void Update(){

   }
  

void OnCollisionEnter(Collision col){

            if( (key_d7.GetComponent<Renderer>().material.color == Color.red)){
   
   sound_d7.Play();
   key_d7.transform.localPosition = new Vector3(-0.876f,2.198f,-0.058f);
            }
      
}
void OnCollisionExit(Collision col){
      
  key_d7.GetComponent<Renderer>().material.color = Color.white;

    key_d7.transform.localPosition = new Vector3(-0.876f,2.51f,-0.058f);
}
}
