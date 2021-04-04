/*
 * Name: George Tang
 * Project: Assignment 9
 * File: UnitHUD.cs
 * Decription: health of player and enemy set to full. If either take damage then the health bar will turn a different color.
 * */
using UnityEngine;
using UnityEngine.UI;


    public class UnitHUD : MonoBehaviour
    {
        [SerializeField] private Text unitName;
        [SerializeField] private Text level;
        [SerializeField] private Image fillImage;

        private int _maxHealth;
        private Unit _unit;

        public void Initialize(Unit unit)
        {
            _unit = unit;
            
            unitName.text = _unit.Name;
            level.text = _unit.Level.ToString();
        }

        public void Update()
        {
            SetHealth();
        }
        
        public void SetHealth()
        {
            if (_unit.Health == 0)
            {
                fillImage.fillAmount = 0;
            }
            else
            {
                fillImage.fillAmount = (float) _unit.Health / _unit.MaxHealth;
            }
        }
    }
