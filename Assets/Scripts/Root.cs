using System.Collections.Generic;
using UnityEngine;

public class Root : MonoBehaviour
{ 
     [SerializeField]
     private AiConfig _config;
     [SerializeField]
     private EnemyView _enemyView;
     
     private SmplePatrolAi _smplePatrolAi;
     [SerializeField] private Camera _camera;

    [SerializeField]
    private SpriteRenderer _background;
    
    [SerializeField]
    private CharacterView _characterView;

    [SerializeField]
    private SpriteAnimationConfig _spriteAnimationConfig;
    
    [SerializeField]
    private CannonView _cannonView;

    [SerializeField] 
    private List<BulletView> _bullets;

    [SerializeField] 
    private List<CoinView> _coinViews;

    private ParalaxManager _paralaxManager;
    private SpriteAnimator _spriteAnimator;
    private MainHeroWalker _mainHeroWalker;
    private AimingMuzzle _aimingMuzzle;
    private BulletsEmitter _bulletsEmitter;
    private CoinsManager _coinsManager;

    private void Start()
    {
        _paralaxManager = new ParalaxManager(_camera, _background.transform);
        _spriteAnimator = new SpriteAnimator(_spriteAnimationConfig);
        _coinsManager = new CoinsManager(_coinViews);
        _mainHeroWalker = new MainHeroWalker(_characterView, _spriteAnimator);
        _mainHeroWalker = new MainHeroWalker(_characterView, _spriteAnimator);
        _aimingMuzzle = new AimingMuzzle(_cannonView.transform, _characterView.transform);
        _bulletsEmitter = new BulletsEmitter(_bullets, _cannonView.MuzzleTransform);
        //_smplePatrolAi = new SmplePatrolAi(_enemyView, new SmplePatrolAiModel(_config));
    }

    private void Update()
    {
        _paralaxManager.Update();
        _spriteAnimator.Update();
        _aimingMuzzle.Update();
        _bulletsEmitter.Update();
    }

    private void FixedUpdate()
    {
        _mainHeroWalker.FixedUpdate();
        //_smplePatrolAi.FixedUpdate();
    }

    private void OnDestroy()
    {
        _coinsManager.Dispose();
    }
}
