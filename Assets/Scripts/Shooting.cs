using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private float shootingDelay = 0f;
    private Rigidbody rb;
    [SerializeField] private GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// Handles the collision with the Spikes. Ignores collision with bullet
    /// </summary>
    /// <param name="other"></param>
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.name != "Bullet(Clone") {
            // Game over
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Debug.Log("<color=green>Bullet Shot</color>");
            shootingDelay = 300f;
            GameObject createdBullet = Instantiate(bullet, transform);
            createdBullet.GetComponent<Rigidbody>().velocity = -transform.forward * 3f;
        }

        if(shootingDelay > 0f) {
            shootingDelay -= 10f;
        }
    }
}
