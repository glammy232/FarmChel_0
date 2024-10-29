using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] private Button _soundBtn;
    [SerializeField] private Button _musicBtn;
    [SerializeField] private Button _vibrationBtn;

    [SerializeField] private Sprite _on;
    [SerializeField] private Sprite _off;

    private void Awake()
    {
        _soundBtn.onClick.AddListener(SetSound);
        _musicBtn.onClick.AddListener(SetMusic);
        _vibrationBtn.onClick.AddListener(SetVibration);
    }

    private void OnEnable() => UpdateUI();

    public void SetSound()
    {
        if (Variables.Sound == 0)
        {
            Variables.Sound = 1;
        }
        else
        {
            Variables.Sound = 0;
        }

        UpdateUI();
    }

    public void SetMusic()
    {
        if (Variables.Music == 0)
        {
            Variables.Music = 1;
        }
        else
        {
            Variables.Music = 0;
        }

        UpdateUI();
    }

    public void SetVibration()
    {
        if (Variables.Vibration == 0)
        {
            Variables.Vibration = 1;
        }
        else
        {
            Variables.Vibration = 0;
        }

        UpdateUI();
    }

    private void UpdateUI()
    {
        if (Variables.Sound == 0)
            _soundBtn.image.sprite = _off;
        else
            _soundBtn.image.sprite = _on;

        if (Variables.Music == 0)
            _musicBtn.image.sprite = _off;
        else
            _musicBtn.image.sprite = _on;

        if (Variables.Vibration == 0)
            _vibrationBtn.image.sprite = _off;
        else
            _vibrationBtn.image.sprite = _on;
    }
}
