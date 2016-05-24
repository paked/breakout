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
        if (Input.GetButtonDown("Jump") && !started) {
			transform.parent = null;
            started = true;

			Vector3 force = new Vector3 (1, 1) * speed * 5;
			if (Random.Range (0f, 1f) > 0.5f) {
				Debug.Log ("force");
				force.x *= -1;
			}

            rb.AddForce(force);
        }
    }
}