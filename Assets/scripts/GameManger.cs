using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
   public void Replay()
    {
        SceneManager.LoadScene("�x�y��");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
