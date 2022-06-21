using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GIroscopio : MonoBehaviour
{
    [SerializeField] Text valores;
    [SerializeField] Text DistanciaText;
    [SerializeField] GameObject controles;
    [SerializeField] GameObject Medidor;
    public float min = 0;
    public float max = -0.7f;
    public float speed = 5;
    public Vector3 girosocopio;
    public float velocidad;
    [SerializeField] Image PrimerDaño;
    [SerializeField] Image SegundoDaño;
    [SerializeField] Image TercerDaño;
    public float distanciaRecorrida;
     int vida = 4;
    public float score=0;
    public bool left;
    public bool right;
    public bool avanzar;
    public bool control = false;//false=control ,true=giroscopio
    Vector3 rotacion;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tilt = Input.acceleration;

        tilt = Quaternion.Euler(90,0,0)*tilt;
        girosocopio = tilt;

        if(control==true)
        {
            if (tilt.x >= 0.2 && transform.rotation.z >= -0.15)
            {
                transform.Rotate(new Vector3(0f, 0f, -30f) * Time.deltaTime);
            }
            else
            {
                if(tilt.x <= -0.2 && transform.rotation.z <= 0.15)
                {
                    transform.Rotate(new Vector3(0f, 0f, 30f) * Time.deltaTime);
                }
            }
            if (tilt.y >= 0.3)
            {
                //velocidad = speed + ((tilt.y - 0.55f)*10);
                if (velocidad >= speed)
                {
                    velocidad = speed;
                }
                else
                {

                    velocidad += Time.deltaTime;
                }
            }
            else
            {
                if (velocidad < 0)
                {
                    velocidad = 0;
                }
                else
                {
                    velocidad -= Time.deltaTime;
                }
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
        }
        else
        {
            if (right == true && transform.rotation.z >= -0.15)
            {
                transform.Rotate(new Vector3(0f, 0f, -30f) * Time.deltaTime);
            }
            else
            {
                if (left == true && transform.rotation.z <= 0.15)
                {
                    transform.Rotate(new Vector3(0f, 0f, 30f) * Time.deltaTime);
                }
            }
            if (avanzar == true)
            {
                if (velocidad >= speed)
                {
                    velocidad = speed;
                }
                else
                {

                    velocidad += Time.deltaTime;
                }
            }
            else
            {
                if (velocidad < 0)
                {
                    velocidad = 0;
                }
                else
                {
                    velocidad -= Time.deltaTime;
                }
            }
            if (avanzar== true)
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
        }
        Debug.Log(velocidad);
        Debug.Log( Medidor.transform.rotation);
        if (tilt.y >= 0.3f || avanzar == true)
        {
            distanciaRecorrida += Time.deltaTime;
        }
        if (avanzar == true || tilt.y>=0.3)
        {if (Medidor.transform.rotation.z >= -1.0f&& Medidor.transform.rotation.w > -0.3f)
            {
                Medidor.transform.Rotate(new Vector3(0f, 0f, -30f) * Time.deltaTime);
            }
        }
        else
        {
            if (Medidor.transform.rotation.z < 0)
            {

                Medidor.transform.Rotate(new Vector3(0f, 0f, 30f) * Time.deltaTime);
            }

        }
        valores.text = "Score: " + score;
        DistanciaText.text = "Dist: " + (int)distanciaRecorrida;
        if(Input.GetKeyDown(KeyCode.E))
        {
            vida = -1;
        }
        if(control==true)
        {
            controles.SetActive(false);
        }
        else { controles.SetActive(true); }
        ComprabarVida();
        FinJuego();
    }
    public void CambiarControl()
    {
        if(control==true)
        {
            control = false;
        }
        else
        {
            control = true;
        }
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
            score += distanciaRecorrida;
            Debug.Log("ENTRO");

            SaveManager.SavePlayerData(this);
            SceneManager.LoadScene("WinMenu");
        }
    }
    public void PressLeft()
    {
        left = true;
    }
    public void PressRigth()
    {
        right = true;
    }
    public void PressAvanzar()
    {
        avanzar = true;
    }
    public void DesPressLeft()
    {
        left = false;
    }
    public void DesPressRigth()
    {
        right = false;
    }
    public void DesPressAvanzar()
    {
        avanzar = false;
    }
}

