using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Rigidbody rb;
    private float x, z;
    public float speed;
    private GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = 20f;
        rb.velocity = transform.forward * speed;
        camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        // If we want to clamp these values
        var moveX = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        var moveY = Input.GetAxis("Vertical") * Time.deltaTime;

        rb.velocity = new Vector3(rb.velocity.x - moveX * 20f, rb.velocity.y, rb.velocity.z - moveY * 20f);
        camera.transform.position = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z + 3f);
    }

    private void FixedUpdate(){
        transform.Translate(x * Time.deltaTime * speed, 0f, z * Time.deltaTime * speed);
    }
}
