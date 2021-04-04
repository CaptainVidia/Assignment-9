/*
 * Name: George Tang
 * Project: Assignment 9
 * File: WonState.cs
 * Decription: stores information of the player and enemy. lets the player that they won the battle in a dialog text
 * */
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


    public class WonState : State
    {
        public WonState(BattleSystem system) : base(system)
        {
        }

        public override IEnumerator Start()
        {
            _system.HUD.SetDialogText("You won the battle!");
            
        yield break;
        }
        
    }
