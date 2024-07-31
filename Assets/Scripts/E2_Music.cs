using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E2_Music : MonoBehaviour
{
  public AudioSource sound_e2;
    public GameObject key_e2;

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


            if((key_e2.GetComponent<Renderer>().material.color == Color.red)){
            Destroy(cubeprefab);
           
    
  sound_e2.Play();
  key_e2.transform.localPosition = new Vector3(0.5089f,2.198f,-0.058f);
}


}void OnCollisionExit(Collision col){
 
  key_e2.GetComponent<Renderer>().material.color = Color.white;

    key_e2.transform.localPosition = new Vector3(0.5089f,2.51f,-0.058f);

}
}
