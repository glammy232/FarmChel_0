using UnityEngine;
using UnityEngine.EventSystems;

public class Sound : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        if (Variables.Sound <= 0)
            return;

        Camera.main.GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("Audio/click"));
    }
}
