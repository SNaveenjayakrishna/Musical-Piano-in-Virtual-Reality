using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A5_script : MonoBehaviour
{
 public AudioSource sound_a5;
  public GameObject key_a5;
  
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
  
  
            if( ( key_a5.GetComponent<Renderer>().material.color == Color.red)){
            Destroy(cubeprefab);
           
    sound_a5.Play();
   key_a5.transform.localPosition = new Vector3(-0.478f,2.198f,-0.058f);
            }
     
    
}void OnCollisionExit(Collision col){

  key_a5.GetComponent<Renderer>().material.color = Color.white;

    key_a5.transform.localPosition = new Vector3(-0.478f,2.51f,-0.058f);

}
}
