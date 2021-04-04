/*
 * Name: George Tang
 * Project: Assignment 9
 * File: Unit.cs
 * Decription: stores information of the player and enemy. implement take damage and heal functions
 * */
using System;
using UnityEngine;


    public class Unit : MonoBehaviour
    {
        [SerializeField] private string unitName;
        [SerializeField] private int level;
        [SerializeField] private int health;
        [SerializeField] private int maxHealth;
        [SerializeField] private int damage;

        public string Name => unitName;
        public int Level => level;
        public int Health => health;
        public int MaxHealth => maxHealth;
        public int Damage => damage;

        public bool TakeDamage(int amount)
        {
            health = Math.Max(0, health - amount);
            return health == 0;
        }

        public void Heal(int amount)
        {
            health += amount;
        }
    }
