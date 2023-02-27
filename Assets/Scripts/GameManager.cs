using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private  bool isGravityChange;
    private bool isMoveCamera=false;
    [SerializeField] private Transform mainCamera;
    [SerializeField] private Transform playCameraPosition;
    [SerializeField] private GameObject startSet;


    private float speed = 2;
   
    void Start()
    {
        isGravityChange = false;
        Time.timeScale = 0;
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

        if (Input.GetKey(KeyCode.A)) 
        {
            isMoveCamera = true;
            Time.timeScale = 1;
            startSet.SetActive(false);
        }
            

        if (isMoveCamera)
        {
            mainCamera.position = Vector3.MoveTowards(mainCamera.position, playCameraPosition.position, speed * Time.deltaTime);
            mainCamera.eulerAngles = playCameraPosition.localEulerAngles;
        }



    }
}
