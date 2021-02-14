using UnityEngine;
using UnityEngine.UI;

public class UICounters : MonoBehaviour
{
    public Text scoreText;
    public Text livesText;
    // Update is called once per frame
    void Update()
    {
        DisplayScore();
        DisplayLives();
    }

    public void DisplayScore()
    {
        scoreText.text = "Score: " + Enemy.score;
    }

    public void DisplayLives()
    {
        livesText.text = "Lives Remaining: " + GameController.playerLives;
    }
}
