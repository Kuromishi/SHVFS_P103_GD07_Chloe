using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float MovementSpeed;
    public float JumpHeight;
    public float TurnSpeed;
    public float LookSpeed;
    public Transform CameraContainer;
    private Rigidbody rigidBody;
    private float processedTurnInput;
    private float processedLookInput;
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
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += this.transform.right * -Time.deltaTime * MovementSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += this.transform.right * Time.deltaTime * MovementSpeed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += this.transform.forward * Time.deltaTime * MovementSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += this.transform.forward * -Time.deltaTime * MovementSpeed;
        }

        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");

        if (horizontalInput != 0 || verticalInput != 0)
        {
            anim.SetFloat("Speed", MovementSpeed);
        }
        else
        {
            anim.SetFloat("Speed", 0);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
        {
            canJump = true;

        }
        if (isGround == false)
        {
            anim.SetBool("Grounded", false);
        }
        else
        {
            anim.SetBool("Grounded", true);
        }

        var turnInput = Input.GetAxis("Mouse X");
        processedTurnInput = turnInput;
        var lookInput = Input.GetAxis("Mouse Y");
        processedLookInput = lookInput;
        CameraContainer.Rotate(new Vector3(processedLookInput, 0f, 0f) * LookSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        rigidBody.MoveRotation(Quaternion.Euler(transform.eulerAngles + (Vector3.up * processedTurnInput) * TurnSpeed * Time.deltaTime));
        if (canJump)
        {
            rigidBody.AddForce(new Vector3(0, JumpHeight, 0));
            canJump = false;
        }
    }

    public void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.GetComponent<ground>() != null)
        {
            isGround = true;
        }

    }
    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.GetComponent<ground>() != null)
        {
            isGround = false;
        }
    }
}
