using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 5.0f;
    
    // Start is called before the first frame update
    public void EndGame(){
        if(!gameHasEnded){
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart(){
        SceneManager.LoadScene(
            SceneManager.GetActiveScene().name
        );
    }
}
