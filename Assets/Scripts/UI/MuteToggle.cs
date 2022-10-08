using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteToggle : MonoBehaviour
{
  public Toggle toggle;

  public void Start()
  {
    SyncToggle();
  }

  public void SetToggle(bool value)
  {
    AudioManager audioManager = GameSys.Instance.audioManager;
    audioManager.isMute = value;
    SyncToggle();
  }

  void SyncToggle()
  {
    bool isMute = GameSys.Instance.audioManager.isMute;
    if (toggle) toggle.isOn = isMute;
  }
}
