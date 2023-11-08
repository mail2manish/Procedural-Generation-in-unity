using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voxelDetect_red : MonoBehaviour
{
    public bool hascollider = false;

    void Start()
    {
       
        Deletevoxel();
    }
    
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("vred"))
        {
            print("collided");
            hascollider = true;
        }
    }
   void Deletevoxel()
   {

    if(hascollider == false)
    {
        Destroy(gameObject);
    }
   }
}
