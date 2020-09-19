﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    public Sprite deadSprite;
    public float health;

    private GameObject heartStorage;
    private PlayerHealthUI playerHealthScript;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        heartStorage = GameObject.Find("Heart Storage");
        playerHealthScript = heartStorage.GetComponent<PlayerHealthUI>();
        health = playerHealthScript.maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        health = playerHealthScript.currentHealth;
        if (health <= 0.0f)
        {
            animator.enabled = false;
            spriteRenderer.sprite = deadSprite;
        }
    }
}