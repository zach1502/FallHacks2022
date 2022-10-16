using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapBackIn5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SwapBack", 5.2f);
    }

    void SwapBack(){
        SceneManager.LoadScene(0);
        SceneManager.UnloadScene(1);
    }
}
