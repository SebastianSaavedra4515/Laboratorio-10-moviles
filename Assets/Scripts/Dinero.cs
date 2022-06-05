using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinero : MonoBehaviour
{
    public float velocidad=10;
    public GIroscopio jugador;
    // Start is called before the first frame update
    void Start()
    {

       

    }

    // Update is called once per frame
    void Update()
    {
        if (jugador.girosocopio.y >= 0.3)
        {



            transform.Translate(Vector3.back * velocidad * Time.deltaTime);
            Debug.Log("avanzar");
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Muro")
        {
            Destroy(gameObject);
        }
        if (other.tag == "MainCamera")
        {
            other.GetComponent<GIroscopio>().score += Random.Range(10, 30);
            Destroy(gameObject);
        }
    }
}
