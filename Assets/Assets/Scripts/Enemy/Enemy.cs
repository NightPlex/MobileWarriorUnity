using UnityEngine;

public abstract class Enemy : MonoBehaviour, IDamageable {
    [SerializeField]
    protected int speed;
    [SerializeField]
    protected int health;
    [SerializeField]
    protected int gems;
    [SerializeField]
    protected Transform pointA, pointB;
    
    private Vector3 _currentTarget;
    private SpriteRenderer _renderer;
    private EnemyAnimation _enemyAnimation;

    public virtual void Attack() {
    }

    protected virtual void Init() {
        _renderer = GetComponentInChildren<SpriteRenderer>();
        _enemyAnimation = GetComponentInChildren<EnemyAnimation>();
        Health = health;
    }

    protected virtual void Start() {
        Init();
    }
    
    public abstract void Update();

    public virtual void HandleMoveAi() {
        if (!_enemyAnimation.WalkState()) return;
        
        if (_currentTarget.x == pointA.position.x) {
            _renderer.flipX = true;
        }
        else {
            _renderer.flipX = false;
        }
        
        if (transform.position.x == pointA.position.x) {
            _currentTarget = pointB.position;
            _enemyAnimation.TriggerIdle();
        }
        else if (transform.position.x == pointB.position.x) {
            _currentTarget = pointA.position;
            _enemyAnimation.TriggerIdle();
        }

        transform.position = Vector3.MoveTowards(transform.position, _currentTarget, speed * Time.deltaTime);
    }

    public int Health { get; set; }

    public virtual void Damage() {
        _enemyAnimation.TriggerGetHit();
        Health = Health - 1;
        if (Health <= 0) {
            _enemyAnimation.TriggerDeath();
            Destroy(gameObject, _enemyAnimation.GetDeathAnimationLength());
        }
    }
}