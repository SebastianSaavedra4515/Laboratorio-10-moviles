using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemis : MonoBehaviour
{
    public List<GameObject> carros = new List<GameObject>();
    float tiempo = 0;
    float TiempoMax=5;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        if(tiempo>=TiempoMax)
        {
            carros[i].transform.position = new Vector3(Random.Range(-3.8f, 3.8f), transform.position.y, transform.position.z);
            
            carros[i].gameObject.SetActive(true);
            i++;
            TiempoMax = Random.Range(10f, 15f);
        }
        if(i>carros.Capacity)
        {
            i = 0;
        }
    }
}
