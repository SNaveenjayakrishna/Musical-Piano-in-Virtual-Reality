using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D5_script : MonoBehaviour
{
       public AudioSource sound_d5;
    public GameObject key_d5;


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

            if((key_d5.GetComponent<Renderer>().material.color == Color.red)){
          
            Destroy(cubeprefab);
    
   sound_d5.Play();
   key_d5.transform.localPosition = new Vector3(-0.318f,2.198f,-0.058f);
        
        }
}
void OnCollisionExit(Collision col){
    
  key_d5.GetComponent<Renderer>().material.color = Color.white;

    key_d5.transform.localPosition = new Vector3(-0.318f,2.51f,-0.058f);
}
}
