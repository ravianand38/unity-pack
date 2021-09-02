using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

   
    public Button menuButton;
    public Button restartButton;
    public bool isGameActive;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI scoreText;
    private int score;
    public float spawnRate = 1.0f;
    public List<GameObject> targets;
    void Start()
    {
        isGameActive = true;
        score = 0;
        
        UpdateScore(0);

        StartCoroutine(SpawnTarget());


    }
   
    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
           
            Instantiate(targets[index]);
        }
    }
    public void UpdateScore(int scoreToAdd)
    {
       
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        isGameActive = false;
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        menuButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
