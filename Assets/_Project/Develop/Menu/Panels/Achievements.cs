using UnityEngine;
using UnityEngine.UI;

public class Achievements : MonoBehaviour
{
    [SerializeField] private Button[] _buttons;

    [SerializeField] private Sprite[] _achievementSprites;

    [SerializeField] private Sprite[] _openedButtonsSprites;

    [SerializeField] private TreasurePanel _ahievementPanel;

    private void Awake() => Initialize();

    private void Initialize()
    {
        for (int i = 0; i < _buttons.Length; i++)
        {
            if (Variables.Achievements[i] > 0)
            {
                _buttons[i].onClick.RemoveAllListeners();

                _buttons[i].image.sprite = _openedButtonsSprites[i];

                int j = i;

                _buttons[i].onClick.AddListener(delegate
                {
                    ButtonMethod(j);
                });
            }
        }
    }

    private void ButtonMethod(int index)
    {
        _ahievementPanel.gameObject.SetActive(true);

        _ahievementPanel.SetImageSprie(_achievementSprites[index]);
    }
}
