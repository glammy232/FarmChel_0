using UnityEngine;
using UnityEngine.SceneManagement;

public class Event : MonoBehaviour
{
    public void Accept()
    {
        GameEntryPoint.IsEvent = true;

        GameEntryPoint.CurrentLevel = Random.Range(6, 9);

        SceneManager.LoadScene("Game");
    }
}
