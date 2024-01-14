using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    private Rigidbody targetRb;
    private GameManager gameManager;

    public int pointValue;
    public ParticleSystem explosionParticle;

    // Start is called before the first frame update
    void Start()
    {
        this.targetRb = GetComponent<Rigidbody>();
        this.gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

        this.targetRb.AddForce(Vector3.up * Random.Range(12, 16), ForceMode.Impulse);
        this.targetRb.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);
        this.transform.position = new Vector3(Random.Range(-4, 4), -6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() {
        if (this.gameManager.isGameActive) {
            Destroy(this.gameObject);
            Instantiate(this.explosionParticle, this.transform.position, this.explosionParticle.transform.rotation);
            this.gameManager.UpdateScore(this.pointValue);
        }
    }

    private void OnTriggerEnter(Collider other) {
        Destroy(this.gameObject);
        if (this.gameObject.CompareTag("Bad")) {
            this.gameManager.GameOver();
        }
    }
}
