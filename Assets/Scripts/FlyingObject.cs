using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingObject : MonoBehaviour
{
    // --------------------------------
    // Variables
    // --------------------------------

    [SerializeField] float speed;
    Rigidbody objectRigidbody;

    // --------------------------------
    // Functions
    // --------------------------------

    void Start()
    {
        // BANANA GO VRRRRRRRR
        objectRigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // BANANA GO UP UP UP!!!
        objectRigidbody.AddForce(speed * transform.up, ForceMode.Impulse);
    }
}
