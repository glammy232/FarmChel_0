using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Levels : MonoBehaviour
{
    [SerializeField] private Button[] _buttons;

    [SerializeField] private Sprite _closeButtonSprite;

    private const string CLOSE_BUTTON_TEXT = "Lock";

    private void OnEnable() => Initialize();

    private void Initialize()
    {
        for (int i = 0; i < _buttons.Length; i++)
        {
            if (i <= Variables.OpenedLevels)
            {
                int j = i;
                _buttons[i].onClick.AddListener(delegate { ButtonMethod(j); });
            }
            else
            {
                _buttons[i].image.sprite = _closeButtonSprite;

                _buttons[i].GetComponentInChildren<TMP_Text>().text = CLOSE_BUTTON_TEXT;
            }
        }
    }

    private void ButtonMethod(int index)
    {
        GameEntryPoint.CurrentLevel = index;

        SceneManager.LoadSceneAsync("Game");
    }
}
