using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorekeep : MonoBehaviour
{
    public static float score = 0;
    public static float highscore = 200;
    public string scoreHolder, hsHolder;
    public Text sText;
    public Text hsText;

    // Update is called once per frame
    void Update()
    {
        //Format scores into string holders and place into the text values
        scoreHolder = string.Format("{0:0000}", score);
        hsHolder = string.Format("{0:0000}", highscore);
        sText.text = "Score: " + scoreHolder.ToString();
        hsText.text = "Highscore: " + hsHolder.ToString();
        //update highschore if overtaken
        if(score > highscore)
        {
            highscore = score;
        }
    }
}
