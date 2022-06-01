using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text score;
    public static int scoreValue;
    //is the game over
    bool gameHasEnded = false;
    public Animator playerAnimator;
    public GameObject mainMenuPanel;
    public Animator mainMenuAnimator;
    public GameObject gameOverPanel;
    public Animator gameOverAnimator;


    private void Update() 
    {
       score.text = "" + scoreValue;     
    }

    public void EndGame()
   {
       if (gameHasEnded == false)
       {
           gameHasEnded = true;
           playerAnimator.enabled = false;
           PlayerMove.FwdSpeed = 0;
           gameOverPanel.SetActive(true);
           GameObject.Find("Player").GetComponent<PlayerMove>().enabled = false;
       }
   }
   public void MainMenu()
   {
      PlayerMove.FwdSpeed = 10;
      scoreValue = 0;
   }
   public void Restart()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

   public void Quit()
   {
       Application.Quit();
   }
}
