using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeIncreaseScore : MonoBehaviour
{
    AudioManager manager;

    private void Awake()
    {
        manager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            manager.PlaySFX(manager.point);
            Score.instance.UpdateScore();
        }
    }
}
