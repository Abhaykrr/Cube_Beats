using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclemovement : MonoBehaviour
{
    public float velocityPlayer=5;
   public Rigidbody cubeLeftRight;
    void Start()
    {
        StartCoroutine (CubeLeft());
    }

   
    void Update()
    {
        
        
    }
    IEnumerator CubeLeft(){
        cubeLeftRight.velocity= new Vector3(-velocityPlayer,0,0);
        yield return new WaitForSeconds(3);
         StartCoroutine (CubeRight());
      


    }
    IEnumerator CubeRight(){
        cubeLeftRight.velocity= new Vector3(velocityPlayer,0,0);
         yield return new WaitForSeconds(3);
         StartCoroutine (CubeLeft());
    
        
    }
}
