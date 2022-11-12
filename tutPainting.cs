using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutPainting : MonoBehaviour
{
    public string tagName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //whenever a bullet hits something, kill itself and the thing it hit
        //only if the tag matches
        if(collision.gameObject.CompareTag(tagName))
        {
           Debug.Log("displaying tutorial button");
        }
    }
}
