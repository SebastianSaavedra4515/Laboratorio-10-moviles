using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Transicion : MonoBehaviour
{
    public float TiempoCambio = 1;
    float tiempo = 0;
    public string ScenaCambio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        if(tiempo>=TiempoCambio)
        {
            SceneManager.LoadScene(ScenaCambio);
        }
    }
}
