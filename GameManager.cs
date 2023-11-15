using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    int score;

    public TextMeshProUGUI scoreText;
    public GameObject gameStart;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameStart()
    {
        gameStart.SetActive(false);
        scoreText.gameObject.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void ScoreUp()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
