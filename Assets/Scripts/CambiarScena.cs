using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarScena : MonoBehaviour
{
    public void CargarScena(string scena)
    {
        SceneManager.LoadScene(scena);
    }
    public void SetActive(GameObject pbject)
    {
        pbject.SetActive(true);
    }
    public void setDesactive(GameObject pbject)
    {
        pbject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
