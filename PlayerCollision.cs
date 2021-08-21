using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public movement Scriptmovement;
    public GameObject collisionUi;
    
   public void OnCollisionEnter(Collision collisioninfo){
       
        if(collisioninfo.collider.tag=="1"){


        Scriptmovement.enabled =false;
        collisionUi.SetActive(true); 
        FindObjectOfType<restart>().endgame();
        FindObjectOfType<PlayerExplosion>().explosion();
        AdmobAds.Instance.ShowRewardedVideo();
               
        }
    }
}
