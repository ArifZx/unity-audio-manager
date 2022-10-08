using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
  public Image image;

  public Sprite spriteOnMute;
  public Sprite spriteOffMute;

  public bool isMute
  {
    get { return audioManager ? audioManager.isMute : false; }
  }

  AudioManager audioManager
  {
    get
    {
      return GameSys.Instance.audioManager;
    }
  }

  void Start()
  {
    SyncButton();
  }

  public void ToggleMute()
  {
    SetMute(!isMute);
  }

  public void SetMute(bool value)
  {
    AudioManager manager = audioManager;
    if (manager == null) return;
    manager.isMute = value;
    SyncButton();
  }

  public void SyncButton()
  {
    if (image == null) return;
    image.sprite = isMute ? spriteOnMute : spriteOffMute;
  }
}
