using System.Collections.Generic;
using UnityEngine;

public class Root : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private SpriteRenderer _background;
    [SerializeField] private CharacterView _characterView;
    [SerializeField] private SpriteAnimationConfig _spriteAnimationConfig;

    private SpriteAnimator _spriteAnimator;

    private void Start()
    {
        _spriteAnimator = new SpriteAnimator(_spriteAnimationConfig);
        _spriteAnimator.StartAnimation(_characterView.SpriteRenderer,Track.jump,true,10f);
    }

    private void Update()
    {
        _spriteAnimator.Uptade();
    }
}
