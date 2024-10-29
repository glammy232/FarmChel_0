using TMPro;
using UnityEngine;

public class RaitingTemplate : MonoBehaviour
{
    public TMP_Text NameText;

    public TMP_Text CoinsText;

    public void Initialize(string nameText, string coinsText)
    {
        NameText.text = nameText;
        CoinsText.text = coinsText;
    }
}
