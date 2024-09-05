using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Superman : MonoBehaviour
{
    [SerializeField] private float forceMagnitude = 1.0f;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody>())
        {
            Vector3 direction = transform.position - collision.transform.position;
            direction = direction.normalized*(-1); // Normalize the direction vector
            collision.rigidbody.AddForceAtPosition(forceMagnitude * direction, collision.transform.position,ForceMode.Impulse);
        }
    }
}
