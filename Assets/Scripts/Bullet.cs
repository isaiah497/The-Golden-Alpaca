﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //Bullet Damage
    public int damage=40;

    //When a bullet collides with anything
    private void OnTriggerEnter(Collider collision)
    {
        switch (collision.tag)
        {
            case "Player":
                break;
            case "Enviroment":
                Destroy(gameObject);
                break;
            case "Enemy":
                EnemyController enemy = collision.GetComponent<EnemyController>();
                if (enemy != null)
                {
                    //If the collsision has an enemy comonent, then damage it
                    enemy.TakeDamage(damage);
                }
                Destroy(gameObject);
                break;
            default:
                break;
        }
        
    }
}