using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C6_script : MonoBehaviour
{ 
    public AudioSource sound_c6;
    public GameObject key_c6;

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
   
            if((key_c6.GetComponent<Renderer>().material.color == Color.red)) {
      
            Destroy(cubeprefab);

   sound_c6.Play();
   key_c6.transform.localPosition = new Vector3(-0.557f,2.198f,-0.058f);

            }
     
}
void OnCollisionExit(Collision col){
       
  key_c6.GetComponent<Renderer>().material.color = Color.white;

    key_c6.transform.localPosition = new Vector3(-0.557f,2.51f,-0.058f);
}
}
