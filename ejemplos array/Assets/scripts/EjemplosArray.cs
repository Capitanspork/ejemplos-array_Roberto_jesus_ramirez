using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemplosArray : MonoBehaviour
{
    public GameObject[] Ballsarrray;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (input.GetKeyDown("space"))
        {
            Instantiate(Ballsarrray(Random.Range(0, 3))
        }
        
    }
}
