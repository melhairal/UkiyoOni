using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleAudioManager : MonoBehaviour
{
    [SerializeField,Header("タイトル用AudioSource")] AudioSource _titleAudioSource;
    [SerializeField, Header("ボタン用SE")] AudioClip _titleButtonClip;
    public void ButtonClickSE()
    {
            _titleAudioSource.PlayOneShot(_titleButtonClip , 1.6f);
            Debug.Log("音が鳴った");
    }
}
