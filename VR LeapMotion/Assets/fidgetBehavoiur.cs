using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fidgetBehavoiur : MonoBehaviour {

    private Vector3 originalPosition;
    float XAngle;
    private Rigidbody rb;
	// Use this for initialization
	void Start () {

        originalPosition = transform.localPosition;
        XAngle = transform.eulerAngles.x;
        rb = GetComponent<Rigidbody>();

    //    rb.AddForce(transform.position);
    }
	
	// Update is called once per frame
	void Update () {
        transform.localPosition = originalPosition;
        transform.eulerAngles = new Vector3(XAngle, 0, transform.eulerAngles.z);
	}

    private void OnCollisionExit(Collision collision)
    {
        rb.AddForce(collision.transform.position);
    }

}
