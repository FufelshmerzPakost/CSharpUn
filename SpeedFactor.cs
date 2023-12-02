using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedFactor : MonoBehaviour
{
    public float speedf = 2.5f;
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedf;
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedf;
    }
}
