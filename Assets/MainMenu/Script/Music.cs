using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    public Button Playb;
    public Button Stopb;
    public Button Pauseb;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource As = gameObject.GetComponent<AudioSource>();

        Playb.onClick.AddListener(delegate(){As.Play();});

        Pauseb.onClick.AddListener(delegate(){As.Pause();});

        Stopb.onClick.AddListener(delegate(){As.Stop();});
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
