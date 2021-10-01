using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Detection : MonoBehaviour
{
   
    void Update()
    {
        transform.Rotate(30 * Time.deltaTime, 0, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            BallMoving.NumberofCounts += 1;
            Destroy(gameObject);
        }

    }
}
