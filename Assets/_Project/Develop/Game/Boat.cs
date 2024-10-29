using UnityEngine;
using UnityEngine.EventSystems;

public class Boat : MonoBehaviour, IClickable, IPointerDownHandler, IMoveable
{
    public void OnClick()
    {
        Variables.Coins += GameConfig.CoinsPerTap + Random.Range(GameConfig.CoinsPerTap, GameConfig.CoinsPerTap * 2);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OnClick();
    }

    public void Move()
    {
        if (transform.position.x > 10)
            Destroy(gameObject);

        transform.position += Vector3.right * 0.1f;
    }
}
