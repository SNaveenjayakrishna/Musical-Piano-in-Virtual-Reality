using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F1_Music : MonoBehaviour
{
      public AudioSource sound_f1;
    
    
 public GameObject key_f1;
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

        if(cubeprefab != null){
    if((key_f1.GetComponent<Renderer>().material.color == Color.red) && (currentCube == key_f1)&& (cubeprefab.transform.position.z < 0.749f)){
      
           Destroy(cubeprefab);
      
    sound_f1.Play();
   key_f1.transform.localPosition = new Vector3(0.7596f,2.198f,-0.058f);

    }
        }
}void OnCollisionExit(Collision col){
   
  key_f1.GetComponent<Renderer>().material.color = Color.white;

    key_f1.transform.localPosition = new Vector3(0.7596f,2.51f,-0.058f);

}
}
