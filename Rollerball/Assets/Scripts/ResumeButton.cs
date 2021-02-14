using UnityEngine;
using UnityEngine.UI;

public class ResumeButton : MonoBehaviour
{
    public Text pauseText;
    
    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseText.text = "Press ESC to pause";
        this.gameObject.SetActive(false);
    }
}