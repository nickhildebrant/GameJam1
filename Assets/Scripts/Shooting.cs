using UnityEngine;
using UnityEngine.SceneManagement;

public class Shooting : MonoBehaviour {
    private float shootingDelay = 0f;
    private Rigidbody rb;
    [SerializeField] private GameObject bullet;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Fire1") && shootingDelay == 0f) {
            Debug.Log("<color=green>Bullet Shot</color>");
            shootingDelay = 300f;
            GameObject createdBullet = Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z - 2f), transform.rotation);
            createdBullet.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, GetComponent<playerController>().speed * 3f);
        }

        if (shootingDelay > 0f) {
            shootingDelay -= 10f;
        }
    }
}
