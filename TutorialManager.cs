using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    public GameObject playerTutorial;
    // Start is called before the first frame update
    void Start()
    {
         playerTutorial.GetComponent<PlayerScript>().canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
