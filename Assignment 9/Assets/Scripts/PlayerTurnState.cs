/*
 * Name: George Tang
 * Project: Assignment 9
 * File: PlayerTurnState.cs
 * Decription: players turn allowuing them to press buttons to attack and heal.
 * */
using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

    public class PlayerTurnState : State
    {
    bool restart = false;

        public PlayerTurnState(BattleSystem system) : base(system)
        {
        }

        public override IEnumerator Start()
        {
            _system.HUD.SetDialogText("Choose an action.");
       
        yield break;
        }

        public override IEnumerator Attack()
        {
            var isDead = _system.EnemyUnit.TakeDamage(_system.PlayerUnit.Damage);
        
            yield return new WaitForSeconds(1f);

            if (isDead)
            {
                _system.SetState(new WonState(_system));
            }
            else
            {
                _system.SetState(new EnemyTurnState(_system));
            }
        }

        public override IEnumerator Heal()
        {
            _system.HUD.SetDialogText($"{_system.PlayerUnit.Name} feels renewed strength!");
            
            _system.PlayerUnit.Heal(100);
        
            yield return new WaitForSeconds(1f);
        
            _system.SetState(new EnemyTurnState(_system));
        }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            restart = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public override bool Restart()
    {
        return restart;
    }

}
