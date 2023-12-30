using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource[] AudioSource_List;
    public AudioSource BG_Audio_Source;
    public AudioSource Word_Audio_Source;
    public AudioSource SoundEffects_Audio_Source;

    public List<AudioClip> Alphabets_Clips = new List<AudioClip>();

    public AudioClip Move_Clip;



    // Start is called before the first frame update

    private void Awake()
    {
        // Ensure there is only one instance of this class
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    private void Start()
    {
        Get_Set_AudioSource();
    }

    public void Get_Set_AudioSource()
    {
        AudioSource_List = Camera.main.GetComponents<AudioSource>();
        BG_Audio_Source = AudioSource_List[0];
        Word_Audio_Source = AudioSource_List[1];
        SoundEffects_Audio_Source = AudioSource_List[2];

    }

    public void Play_Alphabet_Clip(string id)
    {
        AudioClip clip = null;

        for(int i = 0; i < Alphabets_Clips.Count; i++)
        {
            if(id == Alphabets_Clips[i].name)
            {
                clip = Alphabets_Clips[i];
            }
        }

        PlayWordClip(clip);
    }

    public void PlayWordClip(AudioClip clip)
    {
        Word_Audio_Source.Stop();
        Word_Audio_Source.clip = clip;
        Word_Audio_Source.loop = false;
        Word_Audio_Source.Play();
    }

    public void PlaySoundeffectClip(AudioClip clip)
    {
        SoundEffects_Audio_Source.Stop();
        SoundEffects_Audio_Source.clip = clip;
        SoundEffects_Audio_Source.loop = false;
        SoundEffects_Audio_Source.Play();
    }

    public void Play_MoveClip()
    {
        PlayWordClip(Move_Clip);
    }

}
