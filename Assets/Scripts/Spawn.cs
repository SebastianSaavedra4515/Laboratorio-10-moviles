using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float timeMax=4;
    public float time = 0;
    int pos = 0;
    int numHijos;
    // Start is called before the first frame update
    void Start()
    {
        numHijos = this.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time>=timeMax)
        {
            this.transform.GetChild(pos).gameObject.SetActive(true);
            pos=Random.Range(0,numHijos);
            timeMax = Random.Range(2, 4);
            time = 0;
        }
        if(numHijos==pos)
        {
            pos = 0;
        }
    }
}
