using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    public float TimeMax=10;
    float tiempo=0;
    [SerializeField] GameObject coins;
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
            tiempo += Time.deltaTime;
            if (tiempo >= TimeMax)
            {
                coins.transform.position = new Vector3(Random.Range(-3.8f, 3.8f), transform.position.y, transform.position.z);
                coins.GetComponent<Dinero>().jugador = jugador;

                Instantiate(coins);
                tiempo = 0;
                TimeMax = Random.Range(5, 10);
            }
        }
    }
}
