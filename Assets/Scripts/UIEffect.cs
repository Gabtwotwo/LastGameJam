using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIEffect : MonoBehaviour
{
    [SerializeField]
    GameObject image;

    public bool setTrue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            image.gameObject.SetActive(true);
            setTrue = true;

        }
    }
}
