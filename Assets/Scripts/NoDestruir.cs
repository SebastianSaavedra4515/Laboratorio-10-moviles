using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDestruir : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        var noDestruirEntreScenas = FindObjectsOfType<NoDestruir>();
        if(noDestruirEntreScenas.Length>3)
        {
            //Destroy(gameObject);
            return;
        }
        Debug.Log("ok");
        DontDestroyOnLoad(gameObject);
    }
}
