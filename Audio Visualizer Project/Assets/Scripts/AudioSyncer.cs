﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSyncer : MonoBehaviour
{
    public float bias;
    public float timeStep;
    public float timeToBeat;
    public float restSmoothTime;

    private float m_previousAudioValue;
    private float m_AudioValue;
    private float m_timer;

    protected bool m_isBeat;

    private void Update()
    {
        OnUpdate();   
    }

    public virtual void OnUpdate()
    {
        m_previousAudioValue = m_AudioValue;
        m_AudioValue = AudioSpectrum.spectrumValue;

        if(m_previousAudioValue > bias && m_AudioValue <= bias)
        {
            if (m_timer > timeStep)
                OnBeat();
        }

        if (m_previousAudioValue <= bias && m_AudioValue > bias)
        {
            if (m_timer > timeStep)
                OnBeat();
        }
    }

    public virtual void OnBeat()
    {
        Debug.Log("beat");
        m_timer = 0;
        m_isBeat = true;
    }
}