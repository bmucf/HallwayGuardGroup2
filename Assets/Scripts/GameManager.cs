using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] AudioClip DeathSFX;
    [SerializeField] [Range(0f, 1f)] float Dead = .5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayClip(AudioClip clip, float volume)
    {
        if (clip != null)
        {
            Vector3 cameraPos = Camera.main.transform.position;
            AudioSource.PlayClipAtPoint(clip, cameraPos, volume);
        }
    }
}
