using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerS1 : MonoBehaviour
{

    public GameObject PromptBox;
    private GameObject initPromptBox;

    
    public string painting;
    public bool onPainting;

    void Start(){
        onPainting = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //whenever a bullet hits something, kill itself and the thing it hit
        //only if the tag matches
        if(collision.gameObject.CompareTag(painting))
        {
           initPromptBox = Instantiate(PromptBox, transform.position + (transform.up), Quaternion.identity);
           onPainting = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //whenever a bullet hits something, kill itself and the thing it hit
        //only if the tag matches
        if(collision.gameObject.CompareTag(painting))
        {
           Destroy(initPromptBox);
           onPainting = false;
        }
    }
    

}
