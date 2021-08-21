using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManger : MonoBehaviour
{

public GameObject[] groundtypes;
private float spawnZ=0.0f;
private float groundlength=200.0f;
private int noOfGroundOnScreen=3;
private float safeZone=110.0f;
private List<GameObject> activeGrounds; 
private Transform playerTransform; 
    void Start(){
        activeGrounds=new List<GameObject>();
        playerTransform=GameObject.FindGameObjectWithTag("Player").transform;
        SpawnGround();
        SpawnGround();
        SpawnGround();
       
    }

    
    void Update(){
    
        if(playerTransform.position.z-safeZone>(spawnZ-noOfGroundOnScreen*groundlength)){
        SpawnGround();
        DeleteGround(); 
       
        }
    }

    private void SpawnGround(int prefabIndex=-1){
GameObject go;
go = Instantiate(groundtypes[Random.Range(0,4)] as GameObject);
go.transform.position=Vector3.forward * spawnZ;
spawnZ +=groundlength;
activeGrounds.Add(go);
    }
    private void DeleteGround(){
        Destroy(activeGrounds [0]);
        activeGrounds.RemoveAt (0);
    }
}
