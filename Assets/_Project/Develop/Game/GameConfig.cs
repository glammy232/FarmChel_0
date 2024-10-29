using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameConfig : MonoBehaviour
{
    public static int CoinsPerTap;

    public static int MoveSpeed;

    private int _time;

    [SerializeField] private GameObject _endScreen;

    public void Initialize(int currentLevel, int moveSpeed)
    {
        CoinsPerTap = (currentLevel + 2) * (currentLevel + 2) * (currentLevel + 2);

        MoveSpeed = (moveSpeed + 1);

        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(1f);

        _time++;

        if (_time < 10)
            StartCoroutine(Timer());
        else
            End();

    }

    public void End()
    {
        if (Variables.Vibration > 0)
            Handheld.Vibrate();

        if (Variables.OpenedLevels < GameEntryPoint.CurrentLevel + 1 && GameEntryPoint.IsEvent == false)
        {
            Variables.OpenedLevels = GameEntryPoint.CurrentLevel + 1;
        }

        if (GameEntryPoint.IsEvent)
            GameEntryPoint.IsEvent = false;

        _endScreen.SetActive(true);

        var a0 = Variables.Achievements;

        a0[GameEntryPoint.CurrentLevel] = 1;

        Variables.Achievements = a0;

        if (GameEntryPoint.CurrentLevel + 2 <= Variables.Treasures.Length)
        {
            var a1 = Variables.Treasures;

            a1[GameEntryPoint.CurrentLevel] = 1;

            a1[GameEntryPoint.CurrentLevel + 1] = 1;

            a1[GameEntryPoint.CurrentLevel + 2] = 1;

            Variables.Achievements = a1;
        }

        var record = Variables.Coins - GameEntryPoint.StartCoins;

        if (Variables.Record0 < record)
        {
            Variables.Record0 = record;
            return;
        }

        if (Variables.Record1 < record)
        {
            Variables.Record1 = record;
            return;
        }

        if (Variables.Record2 < record)
        {
            Variables.Record2 = record;
            return;
        }
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Next()
    {
        if (GameEntryPoint.CurrentLevel < 9)
            GameEntryPoint.CurrentLevel++;

        SceneManager.LoadScene("Spin");
    }
}
