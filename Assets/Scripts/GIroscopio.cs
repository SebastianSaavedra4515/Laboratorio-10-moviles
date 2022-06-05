using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GIroscopio : MonoBehaviour
{
    [SerializeField] Text valores;
    [SerializeField] Text valores2;
    public float speed = 5;
    public Vector3 girosocopio;
    public float velocidad;
    [SerializeField] Image PrimerDaño;
    [SerializeField] Image SegundoDaño;
    [SerializeField] Image TercerDaño;
     int vida = 4;
    public float score=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tilt = Input.acceleration;

        tilt = Quaternion.Euler(90,0,0)*tilt;
        girosocopio = tilt;
        valores.text = "Score:" + score;
        valores2.text = "Vida:"+(vida);
       
        if (tilt.x>=0.2 && transform.rotation.z >= -0.15)
        {
            transform.Rotate(new Vector3(0f, 0f, -30f)*Time.deltaTime);
        }
        else
        {
            if (tilt.x <= -0.2 && transform.rotation.z <= 0.15)
            {
                transform.Rotate(new Vector3(0f, 0f, 30f) * Time.deltaTime);
               
            }
        }
        if(tilt.y>= 0.3)
        {
             velocidad = speed + ((tilt.y - 0.55f)*10);
        }
        else
        {
            velocidad = 0;
        }


        if (tilt.y >= 0.3)
        {
            if (transform.rotation.z > 0.05 && transform.position.x >= -5)
            {

                transform.position += Vector3.left * velocidad * Time.deltaTime;
            }

            if (transform.rotation.z < -0.05 && transform.position.x <= 5)
            {

                transform.position += Vector3.right * velocidad * Time.deltaTime;
            }
        }
        ComprabarVida();
        FinJuego();
    }
    public void TomarDaño()
    {if (vida > 0) 
        vida--;
    }
    public void ComprabarVida()
    {
        if(vida<=3)
        {
            PrimerDaño.gameObject.SetActive(true);
        }
        if (vida <= 2)
        {
            SegundoDaño.gameObject.SetActive(true);
        }
        if (vida <= 1)
        {
            TercerDaño.gameObject.SetActive(true);
        }
    }
    void FinJuego()
    {
        if (vida <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
