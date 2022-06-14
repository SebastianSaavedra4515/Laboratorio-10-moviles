using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destruir : MonoBehaviour
{
    GameObject ScoreMana;
    public Text Score;
    public Text BestScore;
    // Start is called before the first frame update
    public void Des()
    {
        
    }
    void Start()
    {
        ScoreMana = GameObject.FindGameObjectWithTag("ManageScore");
    }

    // Update is called once per frame
    void Update()
    {
       // Score.text = "Score:" + ScoreMana.GetComponent<ScoreManager>().ScoreReal;
        //BestScore.text = "Best_Score:" + ScoreMana.GetComponent<ScoreManager>().BestScores;
    }
}
