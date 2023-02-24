using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
   
    [SerializeField] private ScoreManager scoreManager;
    //int verticalCount = 0;
    //bool isHolizontalCheck;

    void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(gameObject.transform.position, new Vector3(1, 0, 0), out hit, 0.5f))
        {
            if (hit.collider.gameObject.tag == "Stage")
            {
                scoreManager.GameOver();
            }
           
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Point")
        {
            Destroy(other.gameObject);
            scoreManager.AddSocre();

        }
    }
    /*
    void OnCollisionEnter(Collision col)
    {
        

        if (col.gameObject.tag == "Stage")
        {
            foreach (ContactPoint point in col.contacts)
            {
                Vector3 relativePoint = transform.InverseTransformPoint(point.point);
                print(relativePoint);
                if (relativePoint.x > 0)
                    isHolizontalCheck = true;
                if (relativePoint.x < 0)
                    isHolizontalCheck = false;

                if (relativePoint.y > 0)
                    verticalCount++;
                if (relativePoint.y < 0)
                    verticalCount--;
                print(verticalCount);
                
            }
            
            if (verticalCount != 4 || verticalCount != -4)
            {
                print("b");
                if (isHolizontalCheck)
                    DestroyPlayer();
            }
            
        }
        
    }
    

    public void DestroyPlayer()
    {
        print("c");
        Destroy(gameObject);
    }
    */
   
}
