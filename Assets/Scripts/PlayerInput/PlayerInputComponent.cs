using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerInputComponent   : MonoBehaviour
{
    public float MovementSpeed;
    public float JumpHeight;
    public float TurnSpeed;
    public float LookSpeed;
    public Transform CameraContainer;
    private Rigidbody rigidBody;
    //Vector3 EulerAngleVelocity;
    private Vector3 processedInput;
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
        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");
        // processedInput = new Vector3(horizontalInput, 0f, verticalInput);
        processedInput = transform.right * horizontalInput + transform.forward*verticalInput;
        //Debug.Log(Mathf.Sqrt(Mathf.Pow(rigidBody.velocity.x,2) + Mathf.Pow(rigidBody.velocity.z,2)));

        if(horizontalInput!=0 || verticalInput !=0)
        {
            anim.SetFloat("Speed", MovementSpeed);
        }
        else
        {
            anim.SetFloat("Speed", 0);
        }
        

        if (Input.GetKeyDown(KeyCode.Space)&&isGround==true)
        {
           canJump = true;
           
        }
        if(isGround==false)
        {
            anim.SetBool("Grounded", false);
        }
        else
        {
            anim.SetBool("Grounded", true);
        }
         


        //transform.Translate(processedInput * MovementSpeed * Time.deltaTime);
        //Debug.Log($"X: {rigidBody.velocity.x}| Y: {rigidBody.velocity.z}");

        //Debug.Log($"Horizontal Input: {horizontalInput} | Vertical Input: {verticalInput}");

        var turnInput = Input.GetAxis("Mouse X");
        processedTurnInput = turnInput;
        var lookInput = Input.GetAxis("Mouse Y");
        processedLookInput = lookInput;
        CameraContainer.Rotate(new Vector3(processedLookInput,0f,0f ) * LookSpeed * Time.deltaTime);
    }
    private void FixedUpdate()
    {
        //rigidBody.AddForce(processedInput * MovementSpeed * Time.fixedDeltaTime,ForceMode.VelocityChange);
       rigidBody.MovePosition(transform.position + (processedInput * MovementSpeed * Time.fixedDeltaTime));
        //  Quaternion deltaRotation= Quaternion.Euler(EulerAngleVelocity * Time.fixedDeltaTime);
        // rigidBody.MoveRotation(rigidBody.rotation * deltaRotation);
        rigidBody.MoveRotation(Quaternion.Euler(transform.eulerAngles + (Vector3.up * processedTurnInput) * TurnSpeed * Time.deltaTime));


        if (canJump)
       {
            rigidBody.AddForce(new Vector3(0, JumpHeight, 0));
;            canJump = false;
       }
       // Debug.Log($"X:{rigidBody.velocity.x}|Y:{rigidBody.velocity.z}");
    }
    public void OnCollisionEnter(Collision collision) //Better way£ºRaycast
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
