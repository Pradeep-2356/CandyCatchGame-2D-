using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject livesHolder;
    public GameObject gameOverPlanel;


    int score = 0;
    int lives = 3;
    bool gameOver = false;

    public Text scoreText;
    private void Awake()
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore()
        {   if(!gameOver)
            {

            score++;
            scoreText.text = score.ToString();
            //print(score);
            }
        }

    public void DecreaseLife()
    {
        if(lives > 0)
        {
            lives--;
            livesHolder.transform.GetChild(lives).gameObject.SetActive(false);

        }

        if(lives <=0)
        {
            gameOver = true;

            GameOver();
        }
    }   
    public void GameOver()
    {   
        CandySpawner.instance.StopSpawningCandies();
        GameObject.Find("Player").GetComponent<PlayerController>().canMove = false;
        gameOverPlanel.SetActive(true);

    }

    public void restart ()
    {
        SceneManager.LoadScene("Game");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
