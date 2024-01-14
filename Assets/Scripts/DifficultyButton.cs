using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;

    public int difficulty;

    // Start is called before the first frame update
    void Start()
    {
        this.button = GetComponent<Button>();
        this.button.onClick.AddListener(this.SetDifficulty); 
        this.gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetDifficulty() {
        Debug.Log(this.gameObject.name + " was clicked");
        this.gameManager.StartGame(this.difficulty);
    }
}
