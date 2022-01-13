using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointer : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.gameObject.name);
      
    }
}
