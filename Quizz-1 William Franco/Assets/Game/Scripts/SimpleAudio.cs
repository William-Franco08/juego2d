using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;
public class SimpleAudio : MonoBehaviour
{
    public static SimpleAudio Instance;

    [Header("Referencias")]
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip Apple;
    [SerializeField] private AudioClip Orange;
    [SerializeField] private AudioClip Kiwi;
    [SerializeField] private AudioClip Banana;
    [SerializeField] private Button nextAudio;

    [SerializeField] List<AudioClip> listClips = new List<AudioClip>();
    [SerializeField] bool loopPlaylist = true;

    private int index = -1;

    private void Awake()
    {
        // Singleton
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        if (nextAudio != null)
        {
            nextAudio.onClick.AddListener(PlayNext);
        }
    }

    private void OnDestroy()
    {
        if (nextAudio != null)
        {
            nextAudio.onClick.RemoveListener(PlayNext);
        }
    }

    public void PlayNext()
    {
        if (listClips == null || listClips.Count == 0 || audioSource == null) return;

        index++;

        if (index >= listClips.Count)
        {
            if (loopPlaylist)
                index = 0;
            else
                index = listClips.Count - 1;
        }

        audioSource.Stop();
        audioSource.clip = listClips[index];
        audioSource.Play();
    }

    public void Sonidos(ItemData item)
    {
        if (audioSource == null) return;

        switch (item.itemType)
        {
            case ItemType.Apple:
                audioSource.PlayOneShot(Apple);
                break;
            case ItemType.Orange:
                audioSource.PlayOneShot(Orange);
                break;
            case ItemType.Kiwi:
                audioSource.PlayOneShot(Kiwi);
                break;
            case ItemType.Banana:
                audioSource.PlayOneShot(Banana);
                break;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
