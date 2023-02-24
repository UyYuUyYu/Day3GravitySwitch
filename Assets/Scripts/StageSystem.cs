using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSystem : MonoBehaviour
{
    private int verticalCount = 0;
    bool isHolizontalCheck;
    private bool isAnimationStarted = false;
    Animator animator;

    private MeshRenderer r;
    void Start()
    {
        animator = GetComponent<Animator>();
        if (transform.position.x < 10f)
        {
            isAnimationStarted = true;
        }
        r = gameObject.GetComponent<MeshRenderer>();
        r.material.EnableKeyword("_EMISSIONINPUT");
    }
    void Update()
    {
        
        if (transform.position.x < 10f&&isAnimationStarted==false)
        {
            animator.SetBool("isAnime", true);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            print("a");
            r.material.SetFloat("_EmissionWeight", 0.8f);
        }
    }
   
   
}
