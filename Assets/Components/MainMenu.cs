using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LaunchGame()
    {
        
        SceneManager.LoadScene("Level 001", LoadSceneMode.Single);
    }

    public void LaunchCredits()
    {
        SceneManager.LoadScene("Credits", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Quit Game", LoadSceneMode.Single);
    }

   
}
