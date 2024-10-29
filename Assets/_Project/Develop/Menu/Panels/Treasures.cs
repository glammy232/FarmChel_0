using UnityEngine;
using UnityEngine.UI;

public class Treasures : MonoBehaviour
{
    [SerializeField] private Button[] _buttons;

    [SerializeField] private Sprite[] _treasureSprites;

    [SerializeField] private Sprite[] _openedButtonsSprites;

    [SerializeField] private TreasurePanel _treasurePanel;

    private void Awake() => Initialize();

    private void Initialize()
    {
        for (int i = 0; i < _buttons.Length; i++)
        {
            if (Variables.Treasures[i] > 0)
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
        Debug.Log(index + " " + _treasureSprites.Length);
        _treasurePanel.gameObject.SetActive(true);

        _treasurePanel.SetImageSprie(_treasureSprites[index]);
    }
}
