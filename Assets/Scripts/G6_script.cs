using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G6_script : MonoBehaviour
{
      public AudioSource sound_g6;
   public GameObject key_g6;
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
   
            if( ( key_g6.GetComponent<Renderer>().material.color == Color.red)){
    
             Destroy(cubeprefab);
          
   sound_g6.Play();
   key_g6.transform.localPosition = new Vector3(-0.716f,2.198f,-0.058f);

            }
     
}void OnCollisionExit(Collision col){

  key_g6.GetComponent<Renderer>().material.color = Color.white;

    key_g6.transform.localPosition = new Vector3(-0.716f,2.51f,-0.058f);

}
}
