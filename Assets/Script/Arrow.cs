using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    Rigidbody rb;
    bool hasHit;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasHit)
        {
            float Angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(Angle, Vector3.forward);
        }
    }

    void OnCollisionEnter(Collision other) {
        Debug.Log(other.relativeVelocity.magnitude);
        hasHit = true;
        rb.velocity = Vector2.zero;
        rb.isKinematic = true;
    }
}
