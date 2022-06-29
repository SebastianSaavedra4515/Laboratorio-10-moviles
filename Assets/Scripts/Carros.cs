using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carros : MonoBehaviour
{
    public float velocidad;
    Vector3 PosInicial;
    // Start is called before the first frame update
    void Start()
    {
        PosInicial=transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * velocidad * Time.deltaTime);

    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Muro")
        {
            gameObject.SetActive(false);
        }
        if (other.tag == "MainCamera")
        {
            other.GetComponent<GIroscopio>().TomarDaño();
        }
    }
    IEnumerator esperarRepos()
    {
        yield return new WaitForSeconds(5f);
       
        PosInicial.x = Random.Range(-3.8f, 3.8f);
        transform.position = PosInicial;
    }
}
