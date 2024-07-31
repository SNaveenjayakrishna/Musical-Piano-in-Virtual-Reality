using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A4_script : MonoBehaviour
{
 public AudioSource sound_a4;
  public GameObject key_a4;
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
  

            if( ( key_a4.GetComponent<Renderer>().material.color == Color.red)){
         
            Destroy(cubeprefab);
           
    sound_a4.Play();
   key_a4.transform.localPosition = new Vector3(-0.194f,2.198f,-0.058f);

}

}void OnCollisionExit(Collision col){

  key_a4.GetComponent<Renderer>().material.color = Color.white;

    key_a4.transform.localPosition = new Vector3(-0.194f,2.51f,-0.058f);

}
}
