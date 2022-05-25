using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Control : MonoBehaviour
{
    [SerializeField] Text Puntos_text;
    [SerializeField] Text Golpes_text;

    float y_inicial = 0;
    public int Puntos = 0;
    public int Golpes = 0;
    public float speed = 2;
    Rigidbody2D rg;
    bool inicio = false;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 tilt = Input.acceleration;
        Puntos_text.text = "Puntos:" + Puntos;
        Golpes_text.text = "Golpes:" + Golpes;
        
        tilt = Quaternion.Euler(90, 0, 0) * tilt;
        if(inicio==false)
        {
            y_inicial = tilt.y;
            inicio = true;
        }
        if (tilt.x >= 0.2 && transform.rotation.z >= -2.65)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            if (tilt.x <= -0.2 && transform.rotation.z <= 2.65)
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
        }
        
        if(tilt.y>=y_inicial+0.2)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
            rg.gravityScale = 0;
        }
        else
        {
            rg.gravityScale = 1;


        }

    }
}
