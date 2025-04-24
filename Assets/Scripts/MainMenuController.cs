using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
 public void play()
 {
    SceneManager.LoadScene("Game");
 }

 public void Exit()
 {
    Application.Quit();
 }
}
