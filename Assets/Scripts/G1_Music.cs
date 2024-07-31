using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G1_Music : MonoBehaviour
{
    public AudioSource sound_g1;
   public GameObject key_g1;
   
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
            if( ( key_g1.GetComponent<Renderer>().material.color == Color.red) && (currentCube == key_g1)&& (cubeprefab.transform.position.z < 0.749f)){
         Destroy(cubeprefab);
            
          
 
    sound_g1.Play();
   key_g1.transform.localPosition = new Vector3(0.7174f,2.198f,-0.058f);
            }
   }
        

}void OnCollisionExit(Collision col){

  key_g1.GetComponent<Renderer>().material.color = Color.white;

    key_g1.transform.localPosition = new Vector3(0.7174f,2.51f,-0.058f);

}
}
