using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public void endgame(){
        Debug.Log("game ended");
        // Invoke("startAgain",2f);

    }
    public void startAgain(){
        SceneManager.LoadScene("Main");

    }
    public void Quit () 
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}
     
}
