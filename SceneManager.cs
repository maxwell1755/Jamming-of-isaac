using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<PlayerScript>().canShoot = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(player.GetComponent<PlayerS1>().onPainting && Input.GetKeyDown(KeyCode.F)){
             UnityEngine.SceneManagement.SceneManager.LoadScene("TutorialStage");
        }
    }
}
