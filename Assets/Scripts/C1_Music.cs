using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C1_Music : MonoBehaviour
{
    public AudioSource sound_c1;
    public GameObject key_c1;
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
if(cubeprefab != null){
  if((key_c1.GetComponent<Renderer>().material.color == Color.red) && (currentCube == key_c1) && (cubeprefab.transform.position.z < 0.749f)) {
      Destroy(cubeprefab);
           
    sound_c1.Play();
   key_c1.transform.localPosition = new Vector3(0.8799f,2.198f,-0.058f);
            }
        }
}


void OnCollisionExit(Collision col){
     
 
  key_c1.GetComponent<Renderer>().material.color = Color.white;

    key_c1.transform.localPosition = new Vector3(0.8799f,2.51f,-0.058f);
}
}






