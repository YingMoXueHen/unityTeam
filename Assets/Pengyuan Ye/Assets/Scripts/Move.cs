using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // public GameObject Player;
    //pmove2 and 3
    public float m_speed = 5f;
    //pmove
    private Move _character;
    
    void Start(){
        //pmove
        //_character = GetComponent<Move>();
    }

    void Update()
    {
        //first
        //pMove();

        pMove2();
        //键盘控制移动
        // PlayerMove_KeyTransform();
    }

    void pMove(){
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(horizontal,0,vertical);
        transform.rotation = Quaternion.LookRotation(dir);
        transform.Translate(Vector3.forward * 3* Time.deltaTime);
    }

    void pMove2(){
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal,0,vertical);
        //transform.rotation = Quaternion.LookRotation(dir);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15f);
        transform.Translate(horizontal * m_speed * Time.deltaTime,0f,vertical * m_speed * Time.deltaTime);
        
    }
 
    //通过Transform组件 键盘控制移动
    // public void PlayerMove_KeyTransform()
    // {
    //     if (Input.GetKey(KeyCode.W) | Input.GetKey(KeyCode.UpArrow)) //前
    //     {
    //         Player.transform.Translate(Vector3.forward * m_speed * Time.deltaTime);
    //     }
    //     if (Input.GetKey(KeyCode.S) | Input.GetKey(KeyCode.DownArrow)) //后
    //     {
    //         Player.transform.Translate(Vector3.forward * -m_speed * Time.deltaTime);
    //     }
    //     if (Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.LeftArrow)) //左
    //     {
    //         Player.transform.Translate(Vector3.right * -m_speed * Time.deltaTime);
    //     }
    //     if (Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.RightArrow)) //右
    //     {
    //         Player.transform.Translate(Vector3.right * m_speed * Time.deltaTime);
    //     }
    // }

}
