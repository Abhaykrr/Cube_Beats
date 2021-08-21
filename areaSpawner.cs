using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// am i changed
public class areaSpawner : MonoBehaviour
{
    private List<GameObject> activeObjects; 
    public GameObject items;
    public float itemXSpread=10;
    public float itemYSpread=0;
    public int noOfItems=100;
    private float spawnZ=0.0f;
    private float groundlength=200.0f;
    private int noOfGroundOnScreen=2;
    private float safeZone=210.0f;
    private Transform playerTransform; 
    GameObject clone;

    public float itemZSpread=10;


    void Start()
    {
        activeObjects=new List<GameObject>();
         playerTransform=GameObject.FindGameObjectWithTag("Player").transform;
                
 
        for(int i=0;i<noOfItems;i++)
                    Spreaditems();

    
                   
    }

     void Update(){

         StartCoroutine (deleteSpreaditems());

        
    
    //   if(playerTransform.position.z%200==0){
    //         deleteSpreaditems();
    //     }
        
    
  
    }


void Spreaditems(){
    Vector3 randPosition=new Vector3(Random.Range(-itemXSpread,itemXSpread),Random.Range(-itemYSpread,itemYSpread),Random.Range(-itemZSpread,itemZSpread))+transform.position;
     clone=Instantiate(items,randPosition,Quaternion.identity);
    activeObjects.Add(clone);
    

}
    
   IEnumerator deleteSpreaditems(){
          yield return new WaitForSeconds(1);
       int length=activeObjects.Count;
        for(int i=0;i<length;i++){
        Destroy(activeObjects [0]);
        activeObjects.RemoveAt (0);
        }
      
    }
}
