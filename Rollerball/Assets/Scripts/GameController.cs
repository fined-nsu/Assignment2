using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public EnemyProducer enemyProducer;
    public GameObject playerPrefab;
    public static GameObject playerObject;
    public Text pauseText;
    public Button resumeButton;
    public static int playerLives;

    // Start is called before the first frame update
    void Start()
    {
        playerLives = 3;
        playerObject = Instantiate(playerPrefab, new Vector3(0, 0.5f, 0), Quaternion.identity) as GameObject;
        var cameraRig = Camera.main.GetComponent<CameraRig>();
        cameraRig.target = playerObject;
        enemyProducer.SpawnEnemies(true);
        var player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        player.onPlayerDeath += onPlayerDeath;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0;
        pauseText.text = "Game is paused";
        pauseText.color = Color.yellow;
        resumeButton.gameObject.SetActive(true);
    }

    void onPlayerDeath(Player player)
    {
        enemyProducer.SpawnEnemies(false);
        Destroy(player.gameObject);
        playerLives--;
        if (playerLives < 1)
        {
            SceneManager.LoadScene(2);
        }
        else
        {
            Invoke("restartGame", 3);
        }
    }

    void restartGame()
    {
        var enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (var enemy in enemies)
        {
            Destroy(enemy);
        }

        playerObject = Instantiate(playerPrefab, new Vector3(0, 0.5f, 0), Quaternion.identity) as GameObject;
        var cameraRig = Camera.main.GetComponent<CameraRig>();
        Player.health = 3;
        cameraRig.target = playerObject;
        enemyProducer.SpawnEnemies(true);
        playerObject.GetComponent<Player>().onPlayerDeath += onPlayerDeath;
    }
}
