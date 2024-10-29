using UnityEngine;
using UnityEngine.EventSystems;

public class Treasure : MonoBehaviour, IClickable, IPointerDownHandler, IMoveable
{
    [SerializeField] private CoinPopUp _popUp;

    private Vector3 _clickPos;

    private const float MOVE_SPEED = 0.1f;

    public void Initialize(CoinPopUp popUp)
    {
        _popUp = popUp;
    }

    private void FixedUpdate()
    {
        //Move();    
    }

    public void OnClick()
    {
        int coins = GameConfig.CoinsPerTap + Random.Range(GameConfig.CoinsPerTap, GameConfig.CoinsPerTap * 2);

        Variables.Coins += coins;

        CoinPopUp newPopUp = Instantiate(_popUp, _clickPos, Quaternion.identity, GameObject.Find("Canvas").transform);

        newPopUp.SetNumber(coins);

        //transform.DOScale(Vector3.one / 1.25f, 0.1f).OnComplete(delegate { transform.DOScale(Vector3.one, 0.1f); });
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _clickPos = Camera.main.ScreenToWorldPoint((Vector3)Input.GetTouch(0).position + new Vector3(0, 0, 10));//eventData.pointerCurrentRaycast.screenPosition;
        OnClick();
    }

    public void Move()
    {
        if (transform.position.x > 10)
            Destroy(gameObject);

        transform.position += Vector3.right * 0.05f;
    }
}
