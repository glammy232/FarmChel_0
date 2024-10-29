using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Improvements : MonoBehaviour
{
    [SerializeField] private TMP_Text _speedCostText;
    [SerializeField] private TMP_Text _capasityCostText;
    [SerializeField] private TMP_Text _compassCostText;
    [SerializeField] private TMP_Text _commandCostText;

    [SerializeField] private Image[] _coinsImages;

    [SerializeField] private int[] _costsOnEverythingLevel;

    [SerializeField] private Button _speedBuyBtn;
    [SerializeField] private Button _capasityBuyBtn;
    [SerializeField] private Button _compassBuyBtn;
    [SerializeField] private Button _commandBuyBtn;

    private void Awake()
    {
        _speedBuyBtn.onClick.AddListener(delegate
        {
            Buy(0);
        });

        _capasityBuyBtn.onClick.AddListener(delegate
        {
            Buy(1);
        });

        _compassBuyBtn.onClick.AddListener(delegate
        {
            Buy(2);
        });

        _commandBuyBtn.onClick.AddListener(delegate
        {
            Buy(3);
        });

        UpdateUI();
    }

    public void Buy(int id)
    {
        if (Variables.Improvements[id] >= 10)
            return;

        if (Variables.Coins < _costsOnEverythingLevel[Variables.Improvements[id]])
            return;

        Variables.Coins -= _costsOnEverythingLevel[Variables.Improvements[id]];

        var array = Variables.Improvements;

        array[id]++;

        Variables.Improvements = array;

        UpdateUI();
    }

    private void UpdateUI()
    {
        _speedCostText.text = _costsOnEverythingLevel[Variables.Improvements[0]].ToString();
        _capasityCostText.text = _costsOnEverythingLevel[Variables.Improvements[1]].ToString();
        _compassCostText.text = _costsOnEverythingLevel[Variables.Improvements[2]].ToString();
        _commandCostText.text = _costsOnEverythingLevel[Variables.Improvements[3]].ToString();

        if (Variables.Improvements[0] >= 10)
        {
            _speedCostText.text = "MAX";
            _speedBuyBtn.interactable = false;
            _coinsImages[0].gameObject.SetActive(false);
        }

        if (Variables.Improvements[1] >= 10)
        {
            _capasityCostText.text = "MAX";
            _capasityBuyBtn.interactable = false;
            _coinsImages[1].gameObject.SetActive(false);
        }

        if (Variables.Improvements[2] >= 10)
        {
            _compassCostText.text = "MAX";
            _compassBuyBtn.interactable = false;
            _coinsImages[2].gameObject.SetActive(false);
        }

        if (Variables.Improvements[3] >= 10)
        {
            _commandCostText.text = "MAX";
            _commandBuyBtn.interactable = false;
            _coinsImages[3].gameObject.SetActive(false);
        }
    }
}
