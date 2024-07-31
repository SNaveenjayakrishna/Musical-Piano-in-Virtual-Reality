using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G4_script : MonoBehaviour
{
    public AudioSource sound_g4;
   public GameObject key_g4;
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
   
      
            if((   key_g4.GetComponent<Renderer>().material.color == Color.red)){
           Destroy(cubeprefab);
            
    
   sound_g4.Play();
   key_g4.transform.localPosition = new Vector3(-0.154f,2.198f,-0.058f);
           
        }

}void OnCollisionExit(Collision col){
 
  key_g4.GetComponent<Renderer>().material.color = Color.white;
 
    key_g4.transform.localPosition = new Vector3(-0.154f,2.51f,-0.058f);

}
}
