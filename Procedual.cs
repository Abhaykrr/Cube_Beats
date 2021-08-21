using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Procedual : MonoBehaviour
{
    public List<GameObject> activeObjects; 
    private Transform playerTransform; 
   
    public GameObject[] items;
   
    void Start()
    { 
        activeObjects=new List<GameObject>();
         playerTransform=GameObject.FindGameObjectWithTag("Player").transform;
        pick();

        //  if(playerTransform.position.z%200==0){
        //      DeleteActiveObjects();
        //  }
    }

    // void Updtae(){
    //      if(playerTransform.position.z%200==0){
    //          DeleteActiveObjects();
    //      }

    // }



void pick(){
    int randomIndex=Random.Range(0,items.Length);
    GameObject clone=Instantiate(items[randomIndex],transform.position,Quaternion.identity);
    activeObjects.Add(clone);
}

 private void DeleteActiveObjects(){
     for(int i=0;i<activeObjects.Count;i++){
        Destroy(activeObjects [0]);
        activeObjects.RemoveAt (0);
     }
    }
    
   
}
