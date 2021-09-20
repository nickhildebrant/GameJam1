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
    /// When colliding with an object tagged Destructable, both get destroyed
    /// </summary>
    /// <param name="other"></param>
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Destructable") {
            Destroy(other.transform.parent.gameObject);
        }
        Destroy(this);
    }
}
