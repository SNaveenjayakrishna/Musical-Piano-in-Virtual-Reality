using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F2_Music : MonoBehaviour
{      public AudioSource sound_f2;

 public GameObject key_f2;
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
void OnCollisionEnter(Collision col)
{

            if( (key_f2.GetComponent<Renderer>().material.color == Color.red)){
      Destroy(cubeprefab);
 
    sound_f2.Play();
   key_f2.transform.localPosition = new Vector3(0.4662f,2.198f,-0.058f);
            }
   

}
void OnCollisionExit(Collision col){

  key_f2.GetComponent<Renderer>().material.color = Color.white;

    key_f2.transform.localPosition = new Vector3(0.4662f,2.51f,-0.058f);

}
}
