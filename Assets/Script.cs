using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public GameObject[] Keys;
    private int currentIndex = 0;
    public string text;
    private float interval = 1.0f;
    private bool isCreatingCube = false;
    private List<string> keystring = new List<string> { "C1", "D1", "E1", "F1", "G1", "A1", "B1", "C2", "D2", "E2", "F2", "G2", "A2", "B2","C3", "D3", "E3", "F3", "G3", "A3", "B3", "C4", "D4", "E4", "F4", "G4", "A4", "B4","C5", "D5", "E5", "F5", "G5", "A5", "B5", "C6", "D6", "E6", "F6", "G6", "A6", "B6"};
   private List<float> xvalues = new List<float> { -0.5506f, -0.5173f, -0.4833f, -0.4485f, -0.4124f, -0.3769f, -0.3432f,-0.3048f,-0.2688f, -0.2338f, -0.1981f, -0.1629f, -0.1267f, -0.0885f-0.0553f, -0.0193f, -0.0157f, -0.0522f, -0.0867f, 0.1208f, 0.1583f,  0.1908f, 0.2274f, 0.262f,  0.2971f, 0.3301f, 0.3646f, 0.4022f, 0.435f,  0.4705f, 0.506f,  0.5399f, 0.5738f, 0.6066f, 0.6411f, 0.6745f, 0.709f,  0.7425f, 0.777f, 0.811f, 0.8455f, 0.8773f};                        
    private float newy = 1.0f, newz = 1.0f, newx = 0.0f;
    private Vector3[] targetPosition;
    private Vector3 faceposition;
    private Vector3 endposition;
    private GameObject currentCube;
    private GameObject previousCube = null;
    private List<GameObject> cloned;
    private List<Vector3> finalposition;
    public float speed = 0.5f;
    private GameObject precube;
    private GameObject colorcube;
    private int index = 0;
    private int textindex = 0;

    public C1_Music Music_c1;
    public D1_Music Music_d1;
    public E1_Music Music_e1;
    public F1_Music Music_f1;
    public G1_Music Music_g1;
    public A1_Music Music_a1;
    public B1_Music Music_b1;
    //2nd Octave
    public C2_Music Music_c2;
    public D2_Music Music_d2;
    public E2_Music Music_e2;
    public F2_Music Music_f2;
    public G2_Music Music_g2;
    public A2_Music Music_a2;
    public B2_Music Music_b2;
       //3rd Octave
    public C3_Music Music_c3;
    public D3_Music Music_d3;
    public E3_Music Music_e3;
    public F3_Music Music_f3;
    public G3_Music Music_g3;
    public A3_Music Music_a3;
    public B3_Music Music_b3;
     //4th Octave
    public C4_script Music_c4;
    public D4_script Music_d4;
    public E4_script Music_e4;
    public F4_script Music_f4;
    public G4_script Music_g4;
    public A4_script Music_a4;
    public B4_script Music_b4;
    //5th Octave
    public C5_script Music_c5;
    public D5_script Music_d5;
    public E5_script Music_e5;
    public F5_script Music_f5;
    public G5_script Music_g5;
    public A5_script Music_a5;
    public B5_script Music_b5;
       //6th Octave
    public C6_script Music_c6;
    public D6_script Music_d6;
    public E6_script Music_e6;
    public F6_script Music_f6;
    public G6_script Music_g6;
    public A6_script Music_a6;
    public B6_script Music_b6;

    void Start()
    {
        text = "C2D2E2B2A2G2F2";
        targetPosition = new Vector3[] {
            //1st Octave ==================================
            new Vector3(-0.5506f, 1.0f, 0.7353f),  // c1
            new Vector3(-0.5173f, 1.0f, 0.7353f),  // d1
            new Vector3(-0.4833f, 1.0f, 0.7353f),  // e1
            new Vector3(-0.4485f, 1.0f, 0.7353f),  // f1
            new Vector3(-0.4124f, 1.0f, 0.7353f),  // g1
            new Vector3(-0.3769f, 1.0f, 0.7353f),  // a1
            new Vector3(-0.3432f, 1.0f, 0.7353f), //b1

            //2nd Octave ==================================
            new Vector3(-0.3048f, 1.0f, 0.7353f),  // c2
            new Vector3(-0.2688f, 1.0f, 0.7353f),  // d2
            new Vector3(-0.2338f, 1.0f, 0.7353f),  // e2
            new Vector3(-0.1981f, 1.0f, 0.7353f),  // f2
            new Vector3(-0.1629f, 1.0f, 0.7353f),  // g2
            new Vector3(-0.1267f, 1.0f, 0.7353f),  // a2
            new Vector3(-0.0885f, 1.0f, 0.7353f), //b2

            //3rd Octave ==================================
            new Vector3(-0.0553f, 1.0f, 0.7353f),  // c3
            new Vector3(-0.0193f, 1.0f, 0.7353f),  // d3
            new Vector3(-0.0157f, 1.0f, 0.7353f),  // e3
            new Vector3(-0.0522f, 1.0f, 0.7353f),  // f3
            new Vector3(-0.0867f, 1.0f, 0.7353f),  // g3
            new Vector3( 0.1208f, 1.0f, 0.7353f),  // a3
            new Vector3(0.1583f, 1.0f, 0.7353f), //b3

            //4th Octave ==================================
            new Vector3(0.1908f, 1.0f, 0.7353f),  // c4
            new Vector3(0.2274f, 1.0f, 0.7353f),  // d4
            new Vector3(0.262f, 1.0f, 0.7353f),  // e4
            new Vector3(0.2971f, 1.0f, 0.7353f),  // f4
            new Vector3(0.3301f, 1.0f, 0.7353f),  // g4
            new Vector3(0.3646f, 1.0f, 0.7353f),  // a4
            new Vector3(0.4022f, 1.0f, 0.7353f), //b4

            //5th Octave
            new Vector3(0.435f, 1.0f, 0.7353f),  // c5
            new Vector3(0.4705f, 1.0f, 0.7353f),  // d5
            new Vector3(0.506f, 1.0f, 0.7353f),  // e5
            new Vector3(0.5399f, 1.0f, 0.7353f),  // f5
            new Vector3(0.5738f, 1.0f, 0.7353f),  // g5
            new Vector3(0.6066f, 1.0f, 0.7353f),  // a5
            new Vector3(0.6411f, 1.0f, 0.7353f), //b5

            //6th Octave
            new Vector3(0.6745f, 1.0f, 0.7353f),  // c6
            new Vector3(0.709f, 1.0f, 0.7353f),  // d6
            new Vector3(0.7425f, 1.0f, 0.7353f),  // e6
            new Vector3(0.777f, 1.0f, 0.7353f),  // f6
            new Vector3(0.811f, 1.0f, 0.7353f),  // g6
            new Vector3(0.8455f, 1.0f, 0.7353f),  // a6
            new Vector3(0.8773f, 1.0f, 0.7353f) //b6
        };

        cloned = new List<GameObject>();
        finalposition = new List<Vector3>();
        StartCoroutine(CreateCubesAtInterval());
    }

void Update()
{
    colorchange();
    MoveTowardstarget();
    for (int i = 1; i < cloned.Count; i++)
    {
        if (cloned[i - 1] != null)
        {
            endposition = GetFrontFacePosition(cloned[i - 1]);
            Vector3 adjustedPosition = new Vector3(cloned[i].transform.position.x, cloned[i].transform.position.y, endposition.z);
            cloned[i].transform.position = adjustedPosition;
        }
    }
}

    IEnumerator CreateCubesAtInterval()
    {
        while (true)
        {
            if (!isCreatingCube)
            {
                isCreatingCube = true;

                if (currentIndex < text.Length - 1)
                {
                    ProcessKey(text[currentIndex].ToString() + text[currentIndex + 1].ToString());
                }

                currentIndex += 2;

                yield return new WaitForSeconds(interval);

                isCreatingCube = false;
            }
            else
            {
                yield return null;
            }
        }
    }

    void ProcessKey(string key)
    {
        GameObject cubePrefab = null;

        for (int i = 0; i < keystring.Count; i++)
        {
            if (key == keystring[i])
            {
                cubePrefab = Keys[i];
                newx = xvalues[i];
                Createcube(cubePrefab, targetPosition[i]);
           
            }
        }
    }
    
   

    void Createcube(GameObject cubePrefab, Vector3 target)
    {
       
        finalposition.Add(target);
        previousCube = currentCube;
 
        if (previousCube != null)
        {
            faceposition = GetFrontFacePosition(previousCube);
        }
      

        currentCube = Instantiate(cubePrefab, new Vector3(newx, newy, newz), cubePrefab.transform.rotation);
        currentCube.transform.localScale = new Vector3(0.02f, 0.03f, 0.2f);
        cloned.Add(currentCube);
       
        

        //Debug.Log("Cloned : " + currentCube);

        if ((previousCube != null ))
        {
            Vector3 adjustedPosition = new Vector3(target.x, target.y, faceposition.z);
            currentCube.transform.position = adjustedPosition;
        }
    }

    Vector3 GetFrontFacePosition(GameObject cube)
    {
        Vector3 size = cube.transform.localScale;
        Vector3 facePosition = cube.transform.position + new Vector3(0, 0, size.z / 1.2f);
        return facePosition;
    }


   void colorchange()
    {
if (textindex < text.Length - 1 && index < cloned.Count && cloned[index] != null){
                    
        for (int i = 0;(i < keystring.Count) && (cloned[index] != null); i++){
            if ((text[textindex].ToString() + text[textindex + 1].ToString()) == keystring[i]){
                colorcube = Keys[i];
                colorcube.GetComponent<Renderer>().material.color = Color.red;
            }
        }
                    
                }
    }

void MoveTowardstarget()
{
    if (index < cloned.Count && cloned[index] != null)
    {
        Vector3 targetPosition = finalposition[index];
        cloned[index].transform.position = Vector3.MoveTowards(cloned[index].transform.position, targetPosition, speed * Time.deltaTime);

        if (colorcube != null)
        {
            if (colorcube == Keys[0])
                Music_c1.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[1])
                Music_d1.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[2])
                Music_e1.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[3])
                Music_f1.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[4])
                Music_g1.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[5])
                Music_a1.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[6])
                Music_b1.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[7])
                Music_c2.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[8])
                Music_d2.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[9])
                Music_e2.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[10])
                Music_f2.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[11])
                Music_g2.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[12])
                Music_a2.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[13])
                Music_b2.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[14])
                Music_c3.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[15])
                Music_d3.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[16])
                Music_e3.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[17])
                Music_f3.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[18])
                Music_g3.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[19])
                Music_a3.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[20])
                Music_b3.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[21])
                Music_c4.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[22])
                Music_d4.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[23])
                Music_e4.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[24])
                Music_f4.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[25])
                Music_g4.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[26])
                Music_a4.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[27])
                Music_b4.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[28])
                Music_c5.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[29])
                Music_d5.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[30])
                Music_e5.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[31])
                Music_f5.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[32])
                Music_g5.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[33])
                Music_a5.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[34])
                Music_b5.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[35])
                Music_c6.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[36])
                Music_d6.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[37])
                Music_e6.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[38])
                Music_f6.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[39])
                Music_g6.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[40])
                Music_a6.handlecube(colorcube, cloned[index]);
            else if (colorcube == Keys[41])
                Music_b6.handlecube(colorcube, cloned[index]);
        
        
        }
    }
    else
    {
        index++;
        textindex += 2;
    }
}

}


