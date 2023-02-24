using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] stage;
    [SerializeField] private Transform generatePosition;
  

    public void StageGenerate()
    {
        
        Instantiate(stage[Random.Range(0,stage.Length)],generatePosition.position, Quaternion.identity);
    }
}
