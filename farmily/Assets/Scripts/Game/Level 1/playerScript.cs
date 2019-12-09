using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public int control;
    public bool rightPressed = false;
    public bool leftPressed = false;
    public float speed;
    public float jumpForce;
    public float radius;
    public float jumpTime;
    public float dirX;

    public float speedArrow;
    public float rotateArrow;
    public float speedTilt;
    public float rotateTilt;

    private float jumpTimeCounter;
    private bool isJumping;
    private bool isGrounded;

    public GameObject resetPosition;
    public eyeFollowing eyeScript;
    public Button up;
    public Transform checkGround;
    public LayerMask whatIsGround;
    public wonCheck win;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        up.onClick.AddListener(turnJump);
    }

    void Update()
    {
        control = PlayerPrefs.GetInt("controller");

        isGrounded = Physics2D.OverlapCircle(checkGround.position, radius, whatIsGround);
        dirX = Input.acceleration.x;

        if (control == 0) {
            if (Input.GetMouseButtonDown(0))
            {
                turnJump();
            }
            if (dirX > 0.1)
            {
                transform.Rotate(Vector3.forward * -rotateTilt);
                rb.velocity = new Vector2(dirX * speedTilt, rb.velocity.y);
                eyeScript.face = 0;
            }
            if (dirX < -0.1)
            {
                transform.Rotate(Vector3.forward * rotateTilt);
                rb.velocity = new Vector2(dirX * speedTilt, rb.velocity.y);
                eyeScript.face = 1;
            }
        }

        if (control == 1) {
            if (rightPressed == true)
            {
                transform.Rotate(Vector3.forward * -rotateArrow);
                rb.velocity = new Vector2(speedArrow, rb.velocity.y);
                eyeScript.face = 0;
            }
            if (leftPressed == true)
            {
                transform.Rotate(Vector3.forward * rotateArrow);
                rb.velocity = new Vector2(-speedArrow, rb.velocity.y);
                eyeScript.face = 1;
            }
        }
    }

    void turnJump()
    {
        if (isGrounded == true)
        {
            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }

        if (isJumping == true)
        {
            if (jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }

        isJumping = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "landGameOver")
        {
            transform.position = resetPosition.transform.position;
        }

        if (collision.gameObject.tag == "anorganic")
        {
            win.anorganic += 1;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "organic")
        {
            win.organic += 1;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "diamond")
        {
            win.diamond += 1;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "gold")
        {
            win.gold += 1;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "silver")
        {
            win.silver += 1;
            Destroy(collision.gameObject);
        }
    }
}
