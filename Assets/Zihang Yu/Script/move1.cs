using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move1 : MonoBehaviour
{
    private CharacterController controller;
    public float Speed = 10f;
    public float RotataSpeed = 1f;
    public float Gravity = -9.8f;
    private Vector3 Veelocity = Vector3.zero;
    public Transform GroundCheck;
    public float CheckRadius= 0.2f;
    private bool IsGround;
    public LayerMask layerMask;
    public float JumpHeight = 3f;
    // Start is called before the first frame update
    void Start()
    {
       controller =  transform.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    private void move()
    {
        IsGround = Physics.CheckSphere(GroundCheck.position, CheckRadius, layerMask);
        if(IsGround && Veelocity.y<0)
        {
            Veelocity.y = 0;
        }

        if(IsGround && Input.GetButtonDown("Jump"))
        {
            Veelocity.y += Mathf.Sqrt(JumpHeight * -2 * Gravity);
        }

        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        var move = transform.forward * Speed * vertical * Time.deltaTime;
        controller.Move(move);

        Veelocity.y += Gravity * Time.deltaTime;
        controller.Move(Veelocity * Time.deltaTime);

        transform.Rotate(Vector3.up,horizontal * RotataSpeed);
    }
}
