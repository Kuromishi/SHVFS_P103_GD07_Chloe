using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float MovementSpeed;
    public float JumpHeight;
    public Transform CameraContainer;
    private Rigidbody rigidBody;
    private bool isGround;
    private bool canJump;
    protected Animator anim;

    private void Awake()
    {
        isGround = true;
        rigidBody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();

    }

    private void Start()
    {
        //EulerAngleVelocity = new Vector3(0, 100, 0);
        anim.SetBool("Grounded", true);
    }

    private void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += this.transform.right * -Time.deltaTime * MovementSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += this.transform.right * Time.deltaTime * MovementSpeed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.position += this.transform.forward * Time.deltaTime * MovementSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.position += this.transform.forward * -Time.deltaTime * MovementSpeed;
        }
    }
}
