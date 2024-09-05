using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private Rigidbody[] allRigidbodies ;

    [SerializeField] private float radius = 5.0f;
    [SerializeField] private float explosionForce = 2.0f;
    [SerializeField] private float upwardsMod = 2.0f;

    void Start()
    {
        allRigidbodies = FindObjectsOfType<Rigidbody>();
        foreach (var rb in allRigidbodies)
        {
            if (Vector3.Distance(rb.position, transform.position) <= radius)
            {
                rb.AddExplosionForce(explosionForce, transform.position, radius, upwardsMod, ForceMode.Impulse);
            }
        }
    }
}
