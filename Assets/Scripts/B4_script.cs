using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B4_script : MonoBehaviour
{
     

  public AudioSource sound_b4;
    public GameObject key_b4;
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

            if( (key_b4.GetComponent<Renderer>().material.color == Color.red)){
            
           
 Destroy(cubeprefab);
    sound_b4.Play();
   key_b4.transform.localPosition = new Vector3(-0.236f,2.198f,-0.058f);
            }
        }
   
void OnCollisionExit(Collision col){
      
  key_b4.GetComponent<Renderer>().material.color = Color.white;

    key_b4.transform.localPosition = new Vector3(-0.236f,2.51f,-0.058f);

}
}
