using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [Header("jump")]
    [SerializeField] float jumpHeight = 1; 
    [SerializeField] float jumpTarget;  
    [SerializeField] float jumpSpeed = 3;  
    [SerializeField] float fallSpeed = 3;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        jump();
    }

    void jump(){
        if(Input.GetKeyDown(KeyCode.Space)){
            jumpTarget = jumpHeight;
        }
        if(jumpTarget > 0){
            transform.Translate(Vector3.up * jumpSpeed * Time.deltaTime);
            if(transform.position.y>= jumpTarget){
                jumpTarget = 0;
            }
        }else
        {
            if(transform.position.y>0.3937778f){
                transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
                if(transform.position.y<0.3937778f){
                    Vector3 newPos = transform.position;
                    newPos.y = 0.3937778f;
                    transform.position = newPos;
                }
            }
        }
    }
}
