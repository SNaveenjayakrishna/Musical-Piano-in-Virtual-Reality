using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D1_Music : MonoBehaviour
{
    public AudioSource sound_d1;
    public GameObject key_d1;
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
            if( (key_d1.GetComponent<Renderer>().material.color == Color.red) && (currentCube == key_d1)&& (cubeprefab.transform.position.z < 0.749f)){
          Destroy(cubeprefab);

    sound_d1.Play();
   key_d1.transform.localPosition = new Vector3(0.8399f,2.198f,-0.058f);
            }
        }
}
  void OnCollisionExit(Collision col){

   
  key_d1.GetComponent<Renderer>().material.color = Color.white;

 
    key_d1.transform.localPosition = new Vector3(0.8399f,2.51f,-0.058f);

}
}
