/*
 * Name: George Tang
 * Project: Assignment 9
 * File: EnemyTurnState.cs
 * Decription: allows the enemy to attack. keeps track of the enemy if they are dead. implement a damage system for enemy.
 * */
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


    public class EnemyTurnState : State
    {
        public EnemyTurnState(BattleSystem system) : base(system)
        {
        }

        public override IEnumerator Start()
        {
            _system.HUD.SetDialogText($"{_system.EnemyUnit.Name} attacks!");
        
            var isDead = _system.PlayerUnit.TakeDamage(_system.EnemyUnit.Damage);

            yield return new WaitForSeconds(1f);

            if (isDead)
            {
                _system.SetState(new LostState(_system));
            }
            else
            {
                _system.SetState(new PlayerTurnState(_system));
            }
        
    }

    
}
