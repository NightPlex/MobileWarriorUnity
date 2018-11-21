using UnityEngine;

public abstract class Enemy : MonoBehaviour{
    public int speed;
    public int health;
    public int gems;
    public Transform pointA, pointB;
    
    public virtual void Attack() {
        
    }

    public abstract void Update();
}
