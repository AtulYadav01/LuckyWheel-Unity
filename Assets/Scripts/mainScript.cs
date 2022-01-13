using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainScript : MonoBehaviour
{

  
    public float Speed = 10;
    public bool isSpinning = true;

    public GameObject pointer;

    void Start()
    {
        pointer.SetActive(false);
    }

    void Update()
    {
        Rotate();
    }

    void Rotate()
    {
        transform.Rotate (0 , 2 * Time.deltaTime, Speed * Time.deltaTime, Space.Self);

        if (isSpinning == false && Speed > 0)
        {
            Stop();
        }
    }

   public void Stop()
    {
        Speed--;

        if(Speed <= 0)
        {
            pointer.GetComponent<BoxCollider> ().enabled = true;
            Speed = 0;
        }
    }

}