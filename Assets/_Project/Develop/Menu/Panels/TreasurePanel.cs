using UnityEngine;
using UnityEngine.UI;

public class TreasurePanel : MonoBehaviour
{
    [SerializeField] private Image _image;

    public void SetImageSprie(Sprite sprite) => _image.sprite = sprite;
}
