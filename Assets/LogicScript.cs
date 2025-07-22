using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int playerScore; // Player's score
    public Text scoreText; // UI Text to display the score
    public GameObject gameOverScreen; // Reference to the Game Over screen UI
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd; // Increment the score
        scoreText.text = playerScore.ToString(); // Update the UI Text with the new score
    }

    public void restartGame()
    {
        Time.timeScale = 1f;
        playerScore = 0; // Reset the score to zero
        scoreText.text = playerScore.ToString(); // Update the UI Text to reflect the reset score
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the current scene to restart the game
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true); // Activate the Game Over screen UI
        Time.timeScale = 0; // Pause the game by setting the time scale to zero
    }
}
