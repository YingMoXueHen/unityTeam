using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class textScore : MonoBehaviour
{
    public static GameObject txt;
    // Start is called before the first frame update
    void Start()
    {
        txt = GameObject.Find("chuansongText");
		txt.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
