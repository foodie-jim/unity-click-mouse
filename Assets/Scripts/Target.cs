using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    private Rigidbody targetRb;

    // Start is called before the first frame update
    void Start()
    {
        this.targetRb = GetComponent<Rigidbody>();
        this.targetRb.AddForce(Vector3.up * Random.Range(12, 16), ForceMode.Impulse);
        this.targetRb.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);
        this.transform.position = new Vector3(Random.Range(-4, 4), -6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other) {
        Destroy(this.gameObject);
    }
}
