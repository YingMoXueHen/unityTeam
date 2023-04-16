using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    
    public int count; 
    
    [SerializeField] private Text scroeText;
    [SerializeField] private Text Text1;
    [SerializeField] private Text Text2;
    [SerializeField] private Text Text3;
    [SerializeField] private Text Text4;
    public int Textcount1; 
    public int Textcount2; 
    public int Textcount3; 
    public int Textcount4; 
    public float movementSpeed = 3;
    public float jumpForce = 300;
    public float timeBeforeNextJump = 1.2f;
    private float canJump = 0f;
    Animator anim;
    Rigidbody rb;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        ControllPlayer();
        //OnTriggerEnter();
    }

    void ControllPlayer()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15f);
            anim.SetInteger("Walk", 1);
        }
        else {
            anim.SetInteger("Walk", 0);
        }

        transform.Translate(movement * movementSpeed * Time.deltaTime, Space.World);

        if (Input.GetButtonDown("Jump") && Time.time > canJump)
        {
                rb.AddForce(0, jumpForce, 0);
                canJump = Time.time + timeBeforeNextJump;
                anim.SetTrigger("jump");
        }
    }

    public void OnTriggerEnter(Collider other){
        if(other.tag == "daoju"){
            Debug.Log("销毁" + other.tag);
            count = count + 50;
            Debug.Log("fenshu:" + count);
            Destroy(other.gameObject);
            scroeText.text = count.ToString();
        }

        if(other.tag == "gaozi"){
            Debug.Log("销毁" + other.tag);
            count = count + 20;
            Textcount1++;
            Debug.Log("fenshu:" + count);
            Destroy(other.gameObject);
            scroeText.text = count.ToString();
            Text1.text = Textcount1.ToString();
        }

        if(other.tag == "jian"){
            Debug.Log("销毁" + other.tag);
            count = count + 10;
            Textcount3++;
            Debug.Log("fenshu:" + count);
            Destroy(other.gameObject);
            scroeText.text = count.ToString();
            Text3.text = Textcount3.ToString();
        }

        if(other.tag == "dao"){
            Debug.Log("销毁" + other.tag);
            count = count + 15;
            Textcount1++;
            Debug.Log("fenshu:" + count);
            Destroy(other.gameObject);
            scroeText.text = count.ToString();
            Text1.text = Textcount1.ToString();
        }

        if(other.tag == "kulou"){
            Debug.Log("销毁" + other.tag);
            count = count + 5;
            Textcount4++;
            Debug.Log("fenshu:" + count);
            Destroy(other.gameObject);
            scroeText.text = count.ToString();
            Text4.text = Textcount4.ToString();
        }

        if(other.tag == "pingzi"){
            Debug.Log("销毁" + other.tag);
            count = count + 40;
            Debug.Log("fenshu:" + count);
            Destroy(other.gameObject);
            scroeText.text = count.ToString();
        }

        if(other.tag == "jingbi"){
            Debug.Log("销毁" + other.tag);
            count = count + 100;
            Textcount2++;
            Debug.Log("fenshu:" + count);
            Destroy(other.gameObject);
            scroeText.text = count.ToString();
            Text2.text = Textcount2.ToString();
        }

        if(other.tag == "chuansong"){
            //Debug.Log("销毁" + other.tag);
            //count = count + 100;
            //Debug.Log("fenshu:" + count);
            //Destroy(other.gameObject);
            //scroeText.text = count.ToString();
            if(count >= 100){
                SceneManager.LoadScene("p2");
            }else{
              
            }
        }

        if(other.tag == "p2"){
            //Debug.Log("销毁" + other.tag);
            //count = count + 100;
            //Debug.Log("fenshu:" + count);
            //Destroy(other.gameObject);
            //scroeText.text = count.ToString();
            if(count >= 100){
                SceneManager.LoadScene("p3");
            }else{
              
            }
        }

        if(other.tag == "p3"){
            //Debug.Log("销毁" + other.tag);
            //count = count + 100;
            //Debug.Log("fenshu:" + count);
            //Destroy(other.gameObject);
            //scroeText.text = count.ToString();
            if(count >= 100){
                SceneManager.LoadScene("p4");
            }else{
              
            }
        }

        if(other.tag == "p4"){
            //Debug.Log("销毁" + other.tag);
            //count = count + 100;
            //Debug.Log("fenshu:" + count);
            //Destroy(other.gameObject);
            //scroeText.text = count.ToString();
            if(count >= 100){
                SceneManager.LoadScene("p5");
            }else{
              
            }
        }
    }

    
}