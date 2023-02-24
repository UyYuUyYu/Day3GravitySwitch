using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageMove : MonoBehaviour
{
    [SerializeField] private StageGenerator stageGenerator;
    [SerializeField] private bool isGenerate=false;
    // Start is called before the first frame update
    void Start()
    {
        stageGenerator = GameObject.Find("Stagegenerator").GetComponent<StageGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(4.0f * Time.deltaTime,0, 0);
        if (isGenerate == false)
        {
            if (transform.position.x < 11)
            {
                stageGenerator.StageGenerate();
                isGenerate = true;
            }
        }

        if (transform.position.x < -12)
        {
            Destroy(gameObject);
        }
        
    }
}
