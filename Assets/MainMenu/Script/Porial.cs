using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(new Vector3 (1.864386f,1.5f, 14.2691f), new Vector3 (0f, 1f, 0f), 0.3f); 
    }
}
