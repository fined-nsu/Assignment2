using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int health = 3;

    public event Action<Player> onPlayerDeath;

    void collidedWithEnemy(Enemy enemy)
    {
        enemy.Attack(this);

        if (health <= 0)
        {
            if (onPlayerDeath != null)
            {
                onPlayerDeath(this);
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        Enemy enemy = col.collider.gameObject.GetComponent<Enemy>();
        if (enemy)
        {
            collidedWithEnemy(enemy);
        }
    }
}
