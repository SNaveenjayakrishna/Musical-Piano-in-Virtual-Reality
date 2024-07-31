using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A2_Music : MonoBehaviour
{
public AudioSource sound_a2;
  public GameObject key_a2;
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
 
            if( ( key_a2.GetComponent<Renderer>().material.color == Color.red)){
            
            Destroy(cubeprefab);
           
    sound_a2.Play();
   key_a2.transform.localPosition = new Vector3(0.383f,2.198f,-0.058f);
            }
     
    
}void OnCollisionExit(Collision col){

  key_a2.GetComponent<Renderer>().material.color = Color.white;

    key_a2.transform.localPosition = new Vector3(0.383f,2.51f,-0.058f);

}
}
