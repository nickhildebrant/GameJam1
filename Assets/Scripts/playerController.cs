using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour {
    private Rigidbody rb;
    public float speed;
    private GameObject camera;

    public string nextLevel;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
        //if (speed == 0) speed = 40;
        speed = 10;
        //rb.velocity = transform.forward * speed;
        camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    /// <summary>
    /// Handles when the ball reaches the end goal or hits a death barrier
    /// </summary>
    /// <param name="other"></param>
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "EndGoal") {
            SceneManager.LoadScene(1);
        }
        if (other.gameObject.tag == "Destructable") {
            // Game over
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    // Update is called once per frame
    void FixedUpdate() {
        // If we want to clamp these values
        var moveX = Input.GetAxis("Horizontal") * Time.deltaTime;
        var moveZ = Input.GetAxis("Vertical") * Time.deltaTime;

        //rb.velocity = new Vector3(rb.velocity.x + moveX * speed * 1.5f, rb.velocity.y - .05f, speed);
        rb.AddForce((new Vector3(moveX, 0.0f, moveZ)) * speed);
        camera.transform.position = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z + 3f);
    }
}