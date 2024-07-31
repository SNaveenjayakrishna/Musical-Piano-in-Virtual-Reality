using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E3_Music : MonoBehaviour
{
 public AudioSource sound_e3;
    public GameObject key_e3;
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

            if((key_e3.GetComponent<Renderer>().material.color == Color.red)){
          
            Destroy(cubeprefab);
            
            sound_e3.Play();
 //  key_e3.GetComponent<Renderer>().material.color = Color.white;
  key_e3.transform.localPosition = new Vector3(0.216f,2.198f,-0.058f);

     
        }
 
  

}void OnCollisionExit(Collision col){

  key_e3.GetComponent<Renderer>().material.color = Color.white;

    key_e3.transform.localPosition = new Vector3(0.216f,2.51f,-0.058f);

}
}
