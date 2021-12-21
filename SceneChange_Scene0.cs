using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange_Scene0 : MonoBehaviour
{
    public void InstructionS()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit !!");
    }
   
}