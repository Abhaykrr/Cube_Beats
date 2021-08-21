using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform Player;
    public Text score;
    public Text highScore;
    public Text Texthighscore;

    void Start()
    {
        highScore.text=PlayerPrefs.GetInt("highScore",0).ToString();
    }

    void Update()
    {   int num1=(int)Player.position.z+164+86;
        score.text=num1.ToString("0");

        if(num1 >PlayerPrefs.GetInt("highScore",0)){
            Texthighscore.text="New High Score";
        PlayerPrefs.SetInt("highScore",num1);
        highScore.text=num1.ToString("0");
        }
    }
}
