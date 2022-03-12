
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


    public float restartDelay = 0f;
    public void EndGame()
    {
        Debug.Log("Game Over!");
        Invoke("Restart",restartDelay);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
