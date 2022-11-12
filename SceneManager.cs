using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.GetComponent<PlayerScript>().popupInited && Input.GetKeyDown(KeyCode.F))
            Debug.Log("load Next Scene");
        
    }
}
