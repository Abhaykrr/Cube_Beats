using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class movement : MonoBehaviour
{
     public movement Scriptmovement;
     public SoundManager soundScript;
     public GameObject collisionUi;
     public Rigidbody rb;
     public GameObject preground;
 float force=1000f;
 public float velocityPlayer=50;
 public float maxVelocity=80;
 bool isleft;
 bool isright;
 bool ispause;

 public void Start(){
     AdmobAds.Instance.ShowBanner();
 }

    void FixedUpdate()
    {
        Destroy(preground,8);
        if(velocityPlayer<maxVelocity){
            velocityPlayer+=.1f*Time.deltaTime;
        }
        rb.velocity= new Vector3(0,0,velocityPlayer);
      
 

        if(Input.GetKey(KeyCode.LeftArrow)){
            rb.AddForce(-force*Time.deltaTime,0,0,ForceMode.VelocityChange);
              }



        if(Input.GetKey(KeyCode.RightArrow)){
               rb.AddForce(force*Time.deltaTime,0,0,ForceMode.VelocityChange);              
    
        }

        if(isleft){
              rb.AddForce(-force*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        
        if(isright){
              rb.AddForce(force*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        
         if(rb.position.x>=-250&&rb.position.x<=250){

         }
         else{
              SceneManager.LoadScene("Main");
              Scriptmovement.enabled =false;
              collisionUi.SetActive(true); 
             AdmobAds.Instance.ShowInterstitial();
              FindObjectOfType<restart>().endgame();
               
               
             }

       
    }
public void Pointerdown(){
   isleft=true;
    // rb.AddForce(-force*Time.deltaTime,0,0,ForceMode.VelocityChange);
}

public void Pointerup(){
    isleft=false;
     // rb.AddForce(force*Time.deltaTime,0,0,ForceMode.VelocityChange); 
}



public void pointerdownRight(){
    isright=true;
}

public void pointerupRight(){
    isright=false;
}




       public void Pause(){
           if(ispause){
               Time.timeScale=1;
               ispause=false;
               AudioListener.pause=false;
               /// soundScript.enabled =true;
           }
           else{
               Time.timeScale=0;
               ispause=true;
                AudioListener.pause=true;
               /// soundScript.enabled =false;
           }
       } 

}
