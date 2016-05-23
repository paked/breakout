using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {
    void OnCollisionEnter(Collision collider) {
        Destroy(gameObject);
    }
}
