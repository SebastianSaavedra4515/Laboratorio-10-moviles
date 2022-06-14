using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TopMenu : MonoBehaviour
{
    [SerializeField] Text puesto1;
    [SerializeField] Text puesto2;
    [SerializeField] Text puesto3;
    ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = SaveManager.LoadPLayerData();
        scoreManager.scores[1] = 75;

        scoreManager.OrdenarPuntaje();
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreManager != null)
        {


            if (scoreManager.scores[0] != 0)
            {
                puesto1.text = "score: " +(int) scoreManager.scores[0];
            }
            else { puesto1.text = "Vacio"; }


            if (scoreManager.scores[1] != 0)
            {
                puesto2.text = "score: " + (int)scoreManager.scores[1];
            }
            else { puesto2.text = "Vacio"; }

            if (scoreManager.scores[2] != 0)
            {
                puesto3.text = "score: " + (int)scoreManager.scores[2];
            }
            else { puesto3.text = "Vacio"; }
        }
    }
}
