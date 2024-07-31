using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C3_Music : MonoBehaviour
{
     public AudioSource sound_c3;
    public GameObject key_c3;
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


            if((key_c3.GetComponent<Renderer>().material.color == Color.red)) {
     
            Destroy(cubeprefab);
            sound_c3.Play();
           key_c3.GetComponent<Renderer>().material.color = Color.white;
           key_c3.transform.localPosition = new Vector3(0.2991f,2.198f,-0.058f);//0.3117f,2.198f,-0.058f

        }
        }

   


void OnCollisionExit(Collision col){
    
  key_c3.GetComponent<Renderer>().material.color = Color.white;


    key_c3.transform.localPosition = new Vector3(0.2991f,2.51f,-0.058f);//0.3117f,2.51f,-0.058f
}
}
















  /*  void Start()
    {
        // Get the Musical_Note component attached to the same GameObject
        musicalNote = GetComponent<Musical_Note>();
    }
*/
 

   


