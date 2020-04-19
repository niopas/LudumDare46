﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //Sounds
    [SerializeField] AudioClip bacteriaDeath;
    [SerializeField] AudioClip bacteriaBuzz;
    [SerializeField] AudioClip gameOver;


    public void BacteriaDeath()
    {
        AudioSource.PlayClipAtPoint(bacteriaDeath, Vector3.zero);
    }

    public void BacteriaBuzz()
    {
        AudioSource.PlayClipAtPoint(bacteriaBuzz, Vector3.zero);
    }

    public void GameOver()
    {
        AudioSource.PlayClipAtPoint(gameOver, Vector3.zero);
    }
}