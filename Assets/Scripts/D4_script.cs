using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D4_script : MonoBehaviour
{
     public AudioSource sound_d4;
    public GameObject key_d4;


//  private GameObject currentCube;
// private GameObject cubeprefab;
// private int currentIndex;


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

            if((key_d4.GetComponent<Renderer>().material.color == Color.red)){
           
            Destroy(cubeprefab);
           
   sound_d4.Play();
   key_d4.transform.localPosition = new Vector3(-0.031f,2.198f,-0.058f);
            }
       
}
void OnCollisionExit(Collision col){
     
  key_d4.GetComponent<Renderer>().material.color = Color.white;

    key_d4.transform.localPosition = new Vector3(-0.031f,2.51f,-0.058f);
}
}
