/*
 * Name: George Tang
 * Project: Assignment 9
 * File: BeginState.cs
 * Decription: a little introduction similar to Pokemon when a pokemon appears 
 * */
using System.Collections;
using UnityEngine;


    public class BeginState : State
    {
        public BeginState(BattleSystem system) : base(system)
        {
        }

        public override IEnumerator Start()
        {
            _system.HUD.SetDialogText($"A wild {_system.EnemyUnit.Name} approaches...");
            
            yield return new WaitForSeconds(2f);
            
            _system.SetState(new PlayerTurnState(_system));
        }
    }
