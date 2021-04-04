/*
 * Name: George Tang
 * Project: Assignment 9
 * File: BattleSystem.cs
 * Decription: sets up the battle phrase. keeps track of who gets hit, health, and current state of the battle with the use on buttons.
 * */
using UnityEngine;


    public class BattleSystem : MonoBehaviour
    {
        [SerializeField] private HUD hud;
        [SerializeField] private GameObject playerPrefab;
        [SerializeField] private GameObject enemyPrefab;
        [SerializeField] private Transform playerPosition;
        [SerializeField] private Transform enemyPosition;

        private Unit _playerUnit;
        private Unit _enemyUnit;
        private State _currentState;

        public Unit PlayerUnit => _playerUnit;
        public Unit EnemyUnit => _enemyUnit;
        public HUD HUD => hud;

        public void SetState(State state)
        {
            _currentState = state;
            StartCoroutine(_currentState.Start());
        }

        

        public void OnAttackButton()
        {
            StartCoroutine(_currentState.Attack());
        }

        public void OnHealButton()
        {
            StartCoroutine(_currentState.Heal());
        }

        private void Start()
        {
            SetupBattle();
        }

        private void SetupBattle()
        {
            var playerGameObject = Instantiate(playerPrefab, playerPosition);
            _playerUnit = playerGameObject.GetComponent<Unit>();
        
            var enemyGameObject = Instantiate(enemyPrefab, enemyPosition);
            _enemyUnit = enemyGameObject.GetComponent<Unit>();

            hud.Initialize(_playerUnit, _enemyUnit);
            
            SetState(new BeginState(this));
        }
    }
