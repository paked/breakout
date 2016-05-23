using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour {
    public float speed = 300;
    public float clampBetweenMin = -16;
    public float clampBetweenMax = 16;
	
	void Update () {
        float pos = transform.position.x + Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        pos = Mathf.Clamp(pos, clampBetweenMin, clampBetweenMax);

        transform.position = new Vector3(pos, transform.position.y, transform.position.z);
	}
}
