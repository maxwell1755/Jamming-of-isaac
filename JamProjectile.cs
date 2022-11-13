using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JamProjectile : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;
    public string _killTag;
    public PlayerScript playScript;

    // Start is called before the first frame update
    void Start()
    {  
       if(playScript.GetComponent<PlayerScript>().getWhatDirection()){
            rb.velocity = transform.right * speed;
            Debug.Log("facingRight");
        }
        else  if(!playScript.GetComponent<PlayerScript>().getWhatDirection()){  
            rb.velocity = -transform.right * speed;
            Debug.Log("LeftFacing");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag(_killTag))
        {
            enemy enemy  = collision.gameObject.GetComponent<enemy>();
            if((enemy.getHP())-1 == 0){
                //destroy the object we hit
                Destroy(enemy.gameObject);
            }else
            {
                enemy.takeDamage();
            }

            //destroy this bullet
            Destroy(gameObject);
        }

        if(collision.gameObject.CompareTag("box"))
        {
            collision.gameObject.GetComponent<box>().boxRB.velocity =  rb.velocity;
            Destroy(gameObject);
        }
        
    }

    


    
}
