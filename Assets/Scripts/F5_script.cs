using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F5_script : MonoBehaviour
{
        public AudioSource sound_f5;
 public GameObject key_f5;
 
 private GameObject currentCube;
private GameObject cubeprefab;
public Script script;
     void Start(){

   }
   void Update(){

   }
public void handlecube(GameObject cube, GameObject prefab){
    currentCube = cube;
    cubeprefab = prefab;
}


void OnCollisionEnter(Collision col){
{
            if((key_f5.GetComponent<Renderer>().material.color == Color.red)){
           
            Destroy(cubeprefab);
 
    sound_f5.Play();
   key_f5.transform.localPosition = new Vector3(-0.399f,2.198f,-0.058f);
            }
        }

}void OnCollisionExit(Collision col){

  key_f5.GetComponent<Renderer>().material.color = Color.white;

    key_f5.transform.localPosition = new Vector3(-0.399f,2.51f,-0.058f);

}
}
