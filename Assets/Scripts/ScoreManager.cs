using UnityEngine;
using System.Collections;
[System.Serializable]
public class ScoreManager
{
    public float[] scores = new float[3];
    public float score;
    public ScoreManager(GIroscopio player)
    {
        score = player.score;
        scores[0] = 0;
        scores[1] = 0;
        scores[2] = 0;
    }
    public void addScore(float ScoresIntroducir)
    {
        //float menor=0;
        //int posmenor=0;
        //for(int i=0; i<3;i++)
        //{
        //    if (scores[i] <= scores[i+1]&&i+1<3)
        //    {
        //        menor = scores[i];
        //        posmenor = i;
        //    }
        //}
        //for (int i = 0; i < 3; i++)
        //{
        //    if (scores[i] == menor)
        //    {
        //        scores[i] = ScoresIntroducir;
        //        i = 3;
        //    }
        //}
        if(scores[2]<ScoresIntroducir)
        {

            scores[2] = ScoresIntroducir;
        }
    }
    public void OrdenarPuntaje()
    {
       
      for(int i=0;i<scores.Length-1;i++)
        {
            for(int j=0;j<scores.Length-i;j++)
            {
                if (j + 1 <= 2)
                {
                    if (scores[j] < scores[j + 1])
                    {
                        float temporal = scores[j + 1];
                        scores[j + 1] = scores[j];
                        scores[j] = temporal;
                    }
                }
            }
        }
       
    }
}
