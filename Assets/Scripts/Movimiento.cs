using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed = 2;
    Vector3 posInicial;
    public float dist;
    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        dist =transform.position.x - posInicial.x;
        if (dist > 12 || dist < -12)
        {
            Restaurar();
            gameObject.SetActive(false);
        }
    }
    public void Restaurar()
    {
        transform.position = posInicial;
    }
}
