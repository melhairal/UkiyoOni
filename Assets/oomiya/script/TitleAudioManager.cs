using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleAudioManager : MonoBehaviour
{
    [SerializeField,Header("�^�C�g���pAudioSource")] AudioSource _titleAudioSource;
    [SerializeField, Header("�{�^���pSE")] AudioClip _titleButtonClip;
    public void ButtonClickSE()
    {
            _titleAudioSource.PlayOneShot(_titleButtonClip , 1.6f);
            Debug.Log("��������");
    }
}
