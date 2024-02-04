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

    public float backgroundMusicVolume = 0.1f;
    public float SoundEffectsVolume = 1;

    public AudioClip Background_Music;
    public AudioClip Btn_Click;



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

        Get_Set_AudioSource();
    }

    private void Start()
    {
        Play_BAckground_Music();
    }

    public void Get_Set_AudioSource()
    {
        AudioSource_List = Camera.main.GetComponents<AudioSource>();
        BG_Audio_Source = AudioSource_List[0];
        Word_Audio_Source = AudioSource_List[1];
        SoundEffects_Audio_Source = AudioSource_List[2];

        SetAudioVolumes();

    }

    public void SetAudioVolumes()
    {

        // Check if the key has been set
        if (PlayerPrefs.HasKey("BgSoundsON"))
        {
            if (PlayerPrefs.GetInt("BgSoundsON") == 1)
            {
                SetBgVolume(backgroundMusicVolume);
            }
            else
            {
                SetBgVolume(0);
            }
        }
        else
        {
            UI_Manager.instance.settings_Screen.On_BG_Music_On_Btn_Click();
        }


        if (PlayerPrefs.HasKey("SoundEffectsOn"))
        {
            if (PlayerPrefs.GetInt("SoundEffectsOn") == 1)
            {
                SetSoundEffectsVolume(SoundEffectsVolume);
            }
            else
            {
                SetSoundEffectsVolume(0);
            }
        }
        else
        {
            UI_Manager.instance.settings_Screen.On_Sound_Effects_On_Btn_Click();
        }

    }

    public void SetBgVolume(float vol)
    {
        BG_Audio_Source.volume = vol;
    }

    public void SetSoundEffectsVolume(float vol)
    {
        SoundEffects_Audio_Source.volume = vol;
    }

    public void Play_BAckground_Music()
    {
        BG_Audio_Source.Stop();
        BG_Audio_Source.clip = Background_Music;
        BG_Audio_Source.loop = true;
        BG_Audio_Source.Play();
    }
    public void Play_Btn_Click()
    {
        PlaySoundeffectClip(Btn_Click);
    }

    public void Play_Alphabet_Clip(string id)
    {
        AudioClip clip = null;

        for(int i = 0; i < Alphabets_Clips.Count; i++)
        {
            if(id.ToUpper() == Alphabets_Clips[i].name.ToUpper())
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
