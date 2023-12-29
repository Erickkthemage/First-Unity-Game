
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private static SoundManager music;

    // Start is called before the first frame update
    void Start()
    {
        if (music == null)
        {
            music = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
