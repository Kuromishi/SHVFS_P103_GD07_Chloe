using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerID
{
    _P1,
    _P2
}

public class PlayerLogic : MonoBehaviour
{
    float horizontalInput;
    float verticalInput;
    public float movementSpeed;
    public float jumpHeight;
    public float turnSpeed;
    public float lookSpeed;
    public Transform cameraContainer;
    private Rigidbody rigidBody;
    private Vector3 processedInput;
    private float processedTurnInput;
    private float processedLookInput;
    private bool isGround;
    private bool canJump;
    protected Animator anim;
    private float bulletNum;
    //public GameObject gunPrefabs;
    //public Transform gunPrefabsTransform;
    //private GameObject gun;

    // CharacterController characterController;

    [SerializeField]
    PlayerID m_playerID;

    [SerializeField]
    Transform shootSpawnPos;

    [SerializeField]
    GameObject shootItem;


    private void Awake()
    {
        //characterController = GetComponent<CharacterController>();
        rigidBody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();

    }
    private void Start()
    {
        bulletNum = 7;
        anim.SetBool("Grounded", true);
        // gun = Instantiate(gunPrefabs, gunPrefabsTransform.position, Quaternion.identity);
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal" + m_playerID);
        verticalInput = Input.GetAxis("Vertical" + m_playerID);
        processedInput = transform.right * horizontalInput + transform.forward * verticalInput;

        if (horizontalInput != 0 || verticalInput != 0)
        {
            anim.SetFloat("Speed", movementSpeed);
        }
        else
        {
            anim.SetFloat("Speed", 0);
        }

        if (Input.GetButtonDown("Jump" + m_playerID) && isGround == true)
        {
            canJump = true;
        }

        if(Input.GetButtonDown("Fire1" + m_playerID) && bulletNum>0)
        {
            Instantiate(shootItem, shootSpawnPos.transform.position, transform.rotation);
            bulletNum--;
            //if(bulletNum==0)
            //{
            //    Destroy(gun);
            //}
        }

        if (isGround == false)
        {
            anim.SetBool("Grounded", false);
        }
        else
        {
            anim.SetBool("Grounded", true);
        }

        var turnInput = Input.GetAxis("Mouse X" + m_playerID);
        processedTurnInput = turnInput;
        var lookInput = Input.GetAxis("Mouse Y" + m_playerID);
        processedLookInput = lookInput;
        cameraContainer.Rotate(new Vector3(processedLookInput, 0f, 0f) * lookSpeed * Time.deltaTime);
    }
    private void FixedUpdate()
    {
        rigidBody.MovePosition(transform.position + (processedInput * movementSpeed * Time.fixedDeltaTime));
        rigidBody.MoveRotation(Quaternion.Euler(transform.eulerAngles + (Vector3.up * processedTurnInput) * turnSpeed * Time.deltaTime));
        if (canJump)
        {
            rigidBody.AddForce(new Vector3(0, jumpHeight, 0));
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
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<GunSpawn>() != null && bulletNum == 0)
        {

            bulletNum = 7;
           // gun = Instantiate(gunPrefabs, gunPrefabsTransform.position, Quaternion.identity);
        }
    }
}
