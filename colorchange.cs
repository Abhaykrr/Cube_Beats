using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchange : MonoBehaviour
{
   public Material grid;
    void Start()
    {
        
    }

    
    void Update()
    {
      StartCoroutine (Managecolor());
       
    }

    IEnumerator Managecolor(){

        yield return new WaitForSeconds(2);
         grid.color=Color.magenta;
         yield return new WaitForSeconds(2);
         grid.color=Color.grey;
         yield return new WaitForSeconds(2);
         grid.color=Color.cyan;
          yield return new WaitForSeconds(2);
         grid.color=Color.green;
        yield return new WaitForSeconds(2);
         grid.color=Color.blue;
        yield return new WaitForSeconds(2);
         grid.color=Color.gray;
         yield return new WaitForSeconds(2);
         grid.color=Color.clear;
          yield return new WaitForSeconds(2);
         grid.color=Color.red;
        yield return new WaitForSeconds(2);
         grid.color=Color.yellow;
         yield return new WaitForSeconds(2);
         grid.color=Color.clear;


       

       Update();
    }
}
