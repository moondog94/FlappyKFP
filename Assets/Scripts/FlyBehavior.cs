using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class FlyBehavior : MonoBehaviour
{
    [SerializeField] private float _velocity = 1.5f;
    [SerializeField] private float _rotationSpeed = 10f;
    [SerializeField] private AudioManager _audioManager;

    private Rigidbody2D _rb;
    private bool _isPlaying = true;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Mouse.current.leftButton.wasPressedThisFrame
            || Touchscreen.current.press.wasPressedThisFrame
            || Keyboard.current.anyKey.wasPressedThisFrame)
            && _isPlaying)
        {
            _audioManager.PlaySFX(_audioManager.flap);
            _rb.velocity = Vector2.up * _velocity;
        }
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, _rb.velocity.y * _rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _isPlaying = false;
        _audioManager.PlaySFX(_audioManager.death);
        GameManager.instance.GameOver();
        _audioManager.PlaySFX(_audioManager.yls);
    }
}
