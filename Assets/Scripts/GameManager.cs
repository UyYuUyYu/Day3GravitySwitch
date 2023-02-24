using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private  bool isGravityChange;
   
    void Awake()
    {
        isGravityChange = false;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))        
            Physics.gravity = new Vector3(0, ((isGravityChange = !isGravityChange )? 30.0f : -30.0f), 0);

        if (Input.GetKey(KeyCode.Space))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("Main");
        }
            
    }
}
