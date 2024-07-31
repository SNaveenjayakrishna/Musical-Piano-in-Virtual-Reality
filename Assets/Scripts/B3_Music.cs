using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B3_Music : MonoBehaviour
{
    

  public AudioSource sound_b3;
    public GameObject key_b3;
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

            if( (key_b3.GetComponent<Renderer>().material.color == Color.red)){
           Destroy(cubeprefab);
           
           
             sound_b3.Play();
    // key_b3.GetComponent<Renderer>().material.color = Color.white;
   key_b3.transform.localPosition = new Vector3(0.05f,2.198f,-0.058f);
   
     
        }
   
     }
void OnCollisionExit(Collision col){
     
  key_b3.GetComponent<Renderer>().material.color = Color.white;

    key_b3.transform.localPosition = new Vector3(0.05f,2.51f,-0.058f);

}
}
