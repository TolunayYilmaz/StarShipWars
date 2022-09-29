using UnityEngine;
using UnityEngine.UI;

public class UiControl : MonoBehaviour
{
    [SerializeField] GameObject gameOverText;
    [SerializeField] GameObject gameNameText;
    [SerializeField] Text scoreText;
    [SerializeField] Button PlayButton;

    private int score;
    void Start()
    {
        gameOverText.SetActive(false);
        scoreText.gameObject.SetActive(false);

    }

    public void StartedGame()
    {
        ScoreReset(0);
        gameNameText.SetActive(false);
        PlayButton.gameObject.SetActive(false);
        gameOverText.SetActive(false);
        scoreText.gameObject.SetActive(true);
        
    }
    private void ScoreUpdate(int score)
    {
        this.score += score;
        scoreText.text = "Score: " + this.score;
    }
    private void ScoreReset(int score)
    {
        this.score= score;
        scoreText.text = "Score: " + this.score;
    }
    public void DestroyAsteroid(GameObject asteroid)
    {
        switch (asteroid.name[8])
        {
            case '1':
                ScoreUpdate(10);
                break;
            case '2':
                ScoreUpdate(20);
                break;
            case '3':
                ScoreUpdate(30);
                break;
            default:
                ScoreUpdate(0);
                break;
        }
    }
    public void FinishGame()
    {
        gameOverText.SetActive(true);
        PlayButton.gameObject.SetActive(true);
    }

  
}
