using UnityEngine;

public class Music : MonoBehaviour
{
    private void Start()
    {
        if (Variables.Music > 0)
        {
            Camera.main.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>("Audio/bg");
            Camera.main.GetComponent<AudioSource>().Play();
        }
    }
}
