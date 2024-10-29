using TMPro;
using UnityEngine;

public class CoinsUpdater : MonoBehaviour
{
    private void LateUpdate() => GetComponent<TMP_Text>().text = Variables.Coins.ToString();
}
