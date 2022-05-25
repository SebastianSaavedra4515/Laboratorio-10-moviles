using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daño : MonoBehaviour
{

   public Control player;
    Movimiento mov;
    // Start is called before the first frame update
    void Start()
    {
        mov = GetComponent<Movimiento>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
      
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player.Golpes++;
            mov.Restaurar();
            gameObject.SetActive(false);
        }
    }
}
