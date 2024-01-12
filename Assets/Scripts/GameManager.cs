using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;

    private float spawnRate = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(this.SpawnTarget());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnTarget() {
        while (true) {
            yield return new WaitForSeconds(this.spawnRate);
            int index = Random.Range(0, this.targets.Count);
            Instantiate(this.targets[index]);
        }
    }
}
