using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameEnums;
[System.Serializable]
public class Sounds
{
    [SerializeField] private ESoundName _soundName;

    //Nhận vào audioClip, đỡ phải tạo AS
    [SerializeField] private AudioClip _soundAudioClip;

    public ESoundName SoundName { get { return _soundName; } }

    public AudioClip SoundAudioClip { get { return _soundAudioClip; } }
}
