using System.Collections;
using UnityEngine;

public class TreasureSpawner : MonoBehaviour
{
    private Treasure _treasureTemplate;

    private CoinPopUp _popUp;

    private bool _stop;

    private Transform _spawnPoint;

    private Coroutine _spawn;

    public void Initialize(Treasure treasureTemplate, CoinPopUp popUp, Transform spawnPoint)
    {
        _treasureTemplate = treasureTemplate;

        _popUp = popUp;

        _spawnPoint = spawnPoint;

        _spawn = StartCoroutine(Spawn());
    }

    public void StopSpawn() => _stop = true;

    private IEnumerator Spawn()
    {
        yield return new WaitForSeconds(1f);

        Treasure newTreasure = Instantiate(_treasureTemplate, _spawnPoint.position + new Vector3(0, Random.Range(-0.75f, 0.75f)), Quaternion.identity, GameObject.Find("Canvas").transform);

        newTreasure.Initialize(_popUp);

        if (_stop == false)
            _spawn = StartCoroutine(Spawn());
    }
}
