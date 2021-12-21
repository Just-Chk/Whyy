// The script for the game ending from different levels.

using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour
{
    public void End1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void End2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    public void End3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }

    public void End6()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
    }

    public void End7()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 8);
    }

    public void End8()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 9);
    }

    public void End9()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 10);
    }

    public void GameOvr9()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 10);
    }

    public void End11()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 12);
    }

    public void End13()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 14);
    }

    public void End14()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 15);
    }

    public void End15()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 16);
    }
}
