using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EndMEnu : MonoBehaviour
{
    [SerializeField] Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        ScoreManager scoreManager = SaveManager.LoadPLayerData();
        scoreText.text = "Score:" + (int)scoreManager.score;
        Debug.Log("datos cargados"+scoreManager.score);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
