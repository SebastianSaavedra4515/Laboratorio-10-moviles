using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GIroscopio : MonoBehaviour
{
    [SerializeField] Text valores;
    public float x;
    public float y;
    public float z;
    [SerializeField] Text valores2;
    public float speed=2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tilt = Input.acceleration;

        tilt = Quaternion.Euler(90,0,0)*tilt;

        valores.text = tilt.x+ ","+ tilt.y + ","+ tilt.z ;
        valores2.text = transform.rotation.z+".";
       
        if (tilt.x>=0.2 && transform.rotation.z >= -0.15)
        {
            transform.Rotate(new Vector3(0f, 0f, -30f)*Time.deltaTime);
        }
        else
        {
            if (tilt.x <= -0.2 && transform.rotation.z <= 0.15)
            {
                transform.Rotate(new Vector3(0f, 0f, 30f) * Time.deltaTime);
            }
        }
    }
}
