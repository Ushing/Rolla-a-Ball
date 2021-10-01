using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomposition : MonoBehaviour
{
    public GameObject[] RandomPoints;
    public int objNum;
    public int objCount = 0;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            objNum = Random.Range(0, 4);
            objCount = 0;
            while(objCount < 4)
            {
                RandomPoints[objCount].SetActive(false);
                objCount += 1;
            }
            RandomPoints[objNum].SetActive(true);
        }
    }
}
