using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A3_Music : MonoBehaviour
{
 public AudioSource sound_a3;
  public GameObject key_a3;

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
 
            if( ( key_a3.GetComponent<Renderer>().material.color == Color.red)){
       
            Destroy(cubeprefab);
           
            sound_a3.Play();
    
   key_a3.transform.localPosition = new Vector3(0.092f,2.198f,-0.058f);

        }
        }
 
    
    
void OnCollisionExit(Collision col){

  key_a3.GetComponent<Renderer>().material.color = Color.white;
    key_a3.transform.localPosition = new Vector3(0.092f,2.51f,-0.058f);

}
}
