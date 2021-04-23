using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftChoice : MonoBehaviour
{



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponentInChildren<CameraController>().left = true;
        }
    }
}
