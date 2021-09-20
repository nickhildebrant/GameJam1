using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// Handles all collisions
    /// </summary>
    /// <param name="other"></param>
    private void OnCollisionEnter(Collision other) {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
