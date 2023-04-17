using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    

    //Second
    // private Vector3 offset = new Vector3(0,5,4);//相机相对于玩家的位置
    // private Transform target;
    // private Vector3 pos;
    // public float speed = 2;


    // void Start () 
    // {
    //     target = GameObject.FindGameObjectWithTag("Player").transform;

    // }


    // void FixedUpdate() 
    // {
    //     pos = target.position + offset;
    //     this.transform.position = Vector3.Lerp(this.transform.position, pos, speed*Time.deltaTime);//调整相机与玩家之间的距离
    //     Quaternion angel = Quaternion.LookRotation(target.position - this.transform.position);//获取旋转角度
    //     this.transform.rotation = Quaternion.Slerp(this.transform.rotation, angel, speed * Time.deltaTime);

    // }

    //First
    public Transform target;
    public float distanceUp =7f;//相机与目标的竖直高度参数
    public float distanceAway = 6f;//相机与目标的水平距离参数
    public float smooth = 2f;//位置平滑移动插值参数值
    public float camDepthSmooth = 30f;
 
    void Update()
    {
        // 鼠标轴控制相机的远近
        if ((Input.mouseScrollDelta.y < 0 && Camera.main.fieldOfView >= 3) || Input.mouseScrollDelta.y > 0 && Camera.main.fieldOfView <= 80)
        {
            Camera.main.fieldOfView += Input.mouseScrollDelta.y * camDepthSmooth * Time.deltaTime;
        }
    }
 
    void LateUpdate()
    {
        //计算出相机的位置
        Vector3 disPos = target.position + Vector3.up * distanceUp - target.forward * distanceAway;
 
        transform.position = Vector3.Lerp(transform.position, disPos, Time.deltaTime * smooth);
        //相机的角度
        transform.LookAt(target.position);
    }
}
