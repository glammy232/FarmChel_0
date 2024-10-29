using UnityEngine;
using UnityEngine.UI;

public class GameEntryPoint : MonoBehaviour
{
    public static int CurrentLevel = 0;

    public static int StartCoins;

    public static bool IsEvent;

    [SerializeField] private Image _backgroundImage;

    //[SerializeField] private Transform _treasureSpawnPoint;

    //[SerializeField] private Sprite[] _boatSprites;

    [SerializeField] private Sprite[] _backgroundSprites;

    //[SerializeField] private Sprite[] _treasureSprites;

    //[SerializeField] private Treasure _treasureTemplate;

    [SerializeField] private CoinPopUp _popUp;

    //[SerializeField] private Boat _boat;

    [SerializeField] private GameConfig _gameConfig;

    //[SerializeField] private TreasureSpawner _treasureSpawner;

    private void Awake() => Initialize();

    private void Initialize()
    {

        StartCoins = Variables.Coins;

        _backgroundImage.sprite = _backgroundSprites[CurrentLevel];

        _gameConfig.Initialize(CurrentLevel, Variables.Improvements[0]);

        //_treasureSpawner.Initialize(_treasureTemplate, _popUp, _treasureSpawnPoint);
    }
}
