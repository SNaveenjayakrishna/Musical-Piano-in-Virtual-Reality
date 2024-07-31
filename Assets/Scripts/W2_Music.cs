using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W2_Music : MonoBehaviour
{
   
    public GameObject key_w2;

     void Start(){

   }
   void Update(){

   }

void OnCollisionEnter(Collision col){

   key_w2.transform.localPosition = new Vector3(0.961f,2.198f,-0.058f);
   

}
void OnCollisionExit(Collision col){
     

    key_w2.transform.localPosition = new Vector3(0.961f,2.51f,-0.058f);
}
}
