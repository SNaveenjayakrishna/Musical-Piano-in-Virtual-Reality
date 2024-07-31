using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F6_script : MonoBehaviour
{      public AudioSource sound_f6;
 public GameObject key_f6;
 
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

            if((key_f6.GetComponent<Renderer>().material.color == Color.red)){
         
  Destroy(cubeprefab);
    sound_f6.Play();
   key_f6.transform.localPosition = new Vector3(-0.676f,2.198f,-0.058f);
            }
    
}void OnCollisionExit(Collision col){

  key_f6.GetComponent<Renderer>().material.color = Color.white;

    key_f6.transform.localPosition = new Vector3(-0.676f,2.51f,-0.058f);

}
}
