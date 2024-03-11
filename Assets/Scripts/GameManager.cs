using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets; 
    private float spawnRate = 1.0f;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    private int score;


    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
        StartCoroutine(SpawnTargets());
        score = 0;
        UpdateScore(0);
    }



    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnTargets()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int targetIndex = Random.Range(0, targets.Count);
            Instantiate(targets[targetIndex]);
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        if (score < 0)
        {
            score = 0;
        }
        scoreText.text = "Score : " + score;
    }

    public void GameOver()
    {
        isGameActive = false;
        gameOverText.gameObject.SetActive(true);
    }
}
