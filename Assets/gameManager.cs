using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    
    // Start is called before the first frame update
    public void EndGame(){
        if(!gameHasEnded){
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", 0.0f);
        }
    }

    void Restart(){
        // Death Screen.
        SceneManager.LoadScene(1);
    }
}
