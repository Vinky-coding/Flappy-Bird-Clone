using System.ComponentModel;
using System.Runtime.Serialization;
using UnityEngine;

public class AudioManager : MonoBehaviour {
    public static AudioManager Instance {get; private set;}

    [SerializeField] private AudioClip[] soundEffects;
    private AudioSource audioSrc;   
    public enum SoundType
    {
        Jump,
        WingFlap,
        GetHit,
        GetPoint
    } 
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else Destroy(gameObject);
    }
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }
    public static void PlaySound(SoundType sfx, float volumn = 1)
    {
        Instance.audioSrc.PlayOneShot(Instance.soundEffects[(int)sfx],volumn);
    }




}