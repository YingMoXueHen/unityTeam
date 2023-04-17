using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class All : MonoBehaviour
{
    private AudioSource au;

    //public AudioClip bgaudioClip;
    //private AudioSource audio;

    void Start(){
        au = GetComponent<AudioSource>();
    }


    public void Close()
    {
        Application.Quit();//退出应用
    }

    public void ButtononClick1(){
        Application.LoadLevel("p1");
    }

    public void ButtononClick2(){
        Application.LoadLevel("p2");
    }

    public void ButtononClick3(){
        Application.LoadLevel("p3");
    }

    public void ButtononClick4(){
        Application.LoadLevel("p4");
    }

    public void ButtononClick0(){
        Application.LoadLevel("start");
    }

    public void OnExitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    public void Clickfalse()
    {
        gameObject.SetActive(false);
    }

     public void Clickopen()
    {
        gameObject.SetActive(true);
    }

    // public void soundPlay{
    //     if(au.isPlaying){
    //         au.Stop();
    //     }else{
    //         au.Play();
    //     }
    // }

}
