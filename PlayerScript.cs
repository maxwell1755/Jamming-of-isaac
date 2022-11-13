using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    private float moveInput;

    private Rigidbody2D rb;

    private bool facingRight;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask ground;

    public GameObject proj;

    public bool canShoot;


    

    // Start is called before the first frame update
    void Start()
    {
        facingRight = true;
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, ground);

        moveInput = Input.GetAxis("Horizontal");
        
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.UpArrow) && isGrounded){
            rb.velocity = Vector2.up * jumpForce;
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            facingRight = false;
            
        }else if(Input.GetKeyDown(KeyCode.RightArrow)){
            facingRight = true;
            
        }

        if(Input.GetKeyDown(KeyCode.Space) && canShoot){
            GameObject ball = Instantiate(proj, transform.position + (transform.up), Quaternion.identity);
            ball.GetComponent<JamProjectile>().playScript = this;
        }
    }

    public bool getWhatDirection(){
        return facingRight;
    }

     


}
