using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {
    public float startSpeed = 10;

    private float speed;
    private Rigidbody rb;
    private bool started = false;
	void Start () {
        speed = startSpeed;

        rb = GetComponent<Rigidbody>();
	}

    void Update() {
        if (Input.GetButtonDown("Fire1") && !started) {
            started = true;
            rb.AddForce(new Vector3(1, 1) * speed * 5);
        }
    }
}