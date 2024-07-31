using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C4_script : MonoBehaviour
{
 public AudioSource sound_c4;
    public GameObject key_c4;
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

            if((key_c4.GetComponent<Renderer>().material.color == Color.red)) {
    Destroy(cubeprefab);

    sound_c4.Play();
   key_c4.transform.localPosition = new Vector3(0.01f,2.198f,-0.058f);
            }
        }


void OnCollisionExit(Collision col){
        
  key_c4.GetComponent<Renderer>().material.color = Color.white;


    key_c4.transform.localPosition = new Vector3(0.01f,2.51f,-0.058f);
}
}
