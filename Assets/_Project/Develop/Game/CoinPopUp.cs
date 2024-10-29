using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinPopUp : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;

    public void SetNumber(int number)
    {
        _text.text = $"+{number}";

        Move();
    }

    private void Move()
    {
        transform.DOMoveY(transform.position.y + 1f, 2f);

        _text.DOFade(0f, 2f);

        GetComponentInChildren<Image>().DOFade(0f, 2f).OnComplete(delegate { Destroy(gameObject); });
    }
}
