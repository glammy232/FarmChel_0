using TMPro;
using UnityEngine;

public class GemsUpdater : MonoBehaviour
{
    private void LateUpdate() => GetComponent<TMP_Text>().text = Variables.Gems.ToString();
}
