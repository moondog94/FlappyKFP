using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopGround : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _width = 6f;

    private SpriteRenderer _spriteRender;

    private Vector2 _startSize;
    // Start is called before the first frame update
    void Start()
    {
        _spriteRender = GetComponent<SpriteRenderer>();

        _startSize = new Vector2(_spriteRender.size.x, _spriteRender.size.y);
    }

    // Update is called once per frame
    void Update()
    {
        _spriteRender.size = new Vector2(_spriteRender.size.x + _speed * Time.deltaTime, _spriteRender.size.y);

        if (_spriteRender.size.x > _width)
        {
            _spriteRender.size = _startSize;
        }
    }
}
