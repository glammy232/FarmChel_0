using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Spin : MonoBehaviour
{
    public Button SpinBtn;

    public Button Menu0;
    public Button Menu1;

    public TMP_Text Coins;

    public TMP_Text Gems;

    public int[] CoinWins;

    public int[] GemWins;

    public GameObject WinPanel;

    private void Awake()
    {
        Menu0.onClick.AddListener(ToMenu);
        Menu1.onClick.AddListener(ToMenu);
        SpinBtn.onClick.AddListener(delegate
        {
            int index = 45 * Random.Range(9, 24);
            SpinMethod(index);
        });
    }

    public void ToMenu()
    {
        SceneManager.LoadSceneAsync("Menu");
    }

    public void SpinMethod(int degrees)
    {
        transform.DORotate(new Vector3(0, 0, degrees), 2f).OnComplete(delegate
        {
            WinPanel.SetActive(true);

            Coins.text = CoinWins[degrees % 360 / 45].ToString();
            Gems.text = GemWins[degrees % 360 / 45].ToString();

            Variables.Coins += CoinWins[degrees % 360 / 45];
            Variables.Gems += GemWins[degrees % 360 / 45];

            if (Variables.Vibration > 0)
                Handheld.Vibrate();
        });
    }
}
