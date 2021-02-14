using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed;
    public int health;
    public int damage;
    public Transform targetTransform;
    public static int score = 0;

    void FixedUpdate()
    {
        if (targetTransform != null)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, targetTransform.transform.position, Time.deltaTime * moveSpeed);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(this.gameObject);
            score++;
        }
    }

    public void Attack(Player player)
    {
        Player.health -= this.damage;
        Destroy(this.gameObject);
    }

    public void Initialize(Transform target, float moveSpeed, int health)
    {
        this.targetTransform = target;
        this.moveSpeed = moveSpeed - SpeedAdjustment.sliderSpeed;
        this.health = health;
    }

}