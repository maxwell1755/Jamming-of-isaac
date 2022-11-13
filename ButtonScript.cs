using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{

    public GameObject LadderHiders;
    public GameObject Ladder;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        Destroy( LadderHiders);
        Instantiate(Ladder, transform.position + (transform.up), Quaternion.identity);
    }
}
