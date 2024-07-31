using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D3_Music : MonoBehaviour
{
    public AudioSource sound_d3;
    public GameObject key_d3;
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
   
            if((key_d3.GetComponent<Renderer>().material.color == Color.red)){
         
 Destroy(cubeprefab);
            sound_d3.Play();
  //  key_d3.GetComponent<Renderer>().material.color = Color.white;
   key_d3.transform.localPosition = new Vector3(0.2577f,2.198f,-0.058f);
        }
 
   
  
}
void OnCollisionExit(Collision col){
   
  key_d3.GetComponent<Renderer>().material.color = Color.white;

    key_d3.transform.localPosition = new Vector3(0.2577f,2.51f,-0.058f);
}
}
