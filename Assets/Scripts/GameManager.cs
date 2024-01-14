using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    public Button restartButton;
    public GameObject titleScreen;

    private float spawnRate = 1.0f;
    private int scroe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartGame(int difficulty) {
        StartCoroutine(this.SpawnTarget());
        this.scroe = 0;
        this.isGameActive = true;
        this.titleScreen.gameObject.SetActive(false);
        this.spawnRate /= difficulty;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnTarget() {
        while (this.isGameActive) {
            yield return new WaitForSeconds(this.spawnRate);
            int index = Random.Range(0, this.targets.Count);
            Instantiate(this.targets[index]);
        }
    }

    public void UpdateScore(int scoreToAdd) {
        this.scroe += scoreToAdd;
        this.scoreText.text = "Score: " + this.scroe;
    }

    public void GameOver() {
        this.gameOverText.gameObject.SetActive(true);
        this.restartButton.gameObject.SetActive(true);
        this.isGameActive = false;
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
