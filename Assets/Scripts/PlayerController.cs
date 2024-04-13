using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public float rotationSpeed;
    public Animator anim;

    public bool isGrounded;
    public Rigidbody rb;
    public AudioSource playerSFX;
    public AudioClip walkSFX, jumpSFX;
    float walkSFXDelay = 0.5f;
    float currentWalkSFXDelay;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(-Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0,
        //- Input.GetAxis("Vertical") * Time.deltaTime * speed);

        rb.velocity = new Vector3(-Input.GetAxis("Horizontal") * speed, rb.velocity.y, -Input.GetAxis("Vertical") * speed);



        transform.Rotate(0, Input.GetAxis("Mouse X") * rotationSpeed, 0);
        if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
        {
            anim.SetInteger("Move", 1);
            currentWalkSFXDelay += Time.deltaTime;
            if (currentWalkSFXDelay >= walkSFXDelay)
            {
                PlayWalkSFX();
                currentWalkSFXDelay = 0;
            }
        }
        else
        {
            anim.SetInteger("Move", 0);
            CancelInvoke(nameof(PlayWalkSFX));
        }


        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void PlayWalkSFX()
    {
        playerSFX.clip = walkSFX;
        playerSFX.Play();
    }
}
