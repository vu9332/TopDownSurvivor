using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFXManager : AudioManager
{
    public static SoundFXManager Instance { get; set; }
    [Space]
    [Header("SoundFXManager")]
    [SerializeField] public  AudioClip rifleShoot;
    [SerializeField] public  AudioClip pistloShoot;
    [SerializeField] public  AudioClip maleHit;
  

    protected override void Awake()
    {
        base.Awake();
        if (Instance == null)
            Instance = this;
    }
}
