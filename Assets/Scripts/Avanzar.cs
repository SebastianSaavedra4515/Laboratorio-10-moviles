using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avanzar : MonoBehaviour
{
    public GIroscopio jugador;
    public Transform Position;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (jugador.girosocopio.y>=0.3)
        {
            transform.Translate(Vector3.back * jugador.velocidad * Time.deltaTime);
        }
      //  transform.Translate(Vector3.back * jugador.speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if(other.tag=="Muro")
        {
            Debug.Log("entro");
            transform.position = Position.position;
        }
    }

}
