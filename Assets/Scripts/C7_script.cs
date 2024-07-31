using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C7_script : MonoBehaviour
{
    public AudioSource sound_c7;
    public GameObject key_c7;
 

     void Start(){

   }
   void Update(){

   }
 

void OnCollisionEnter(Collision col){

            if((key_c7.GetComponent<Renderer>().material.color == Color.red)) {
       
         
   
   sound_c7.Play();
   key_c7.transform.localPosition = new Vector3(-0.836f,2.198f,-0.058f);
            }
      

}
void OnCollisionExit(Collision col){
      
  key_c7.GetComponent<Renderer>().material.color = Color.white;
  key_c7.transform.localPosition = new Vector3(-0.836f,2.51f,-0.058f);
}
}
