using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billiard : MonoBehaviour
{
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.back, ForceMode.Impulse);
    }
}
