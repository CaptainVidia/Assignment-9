/*
 * Name: George Tang
 * Project: Assignment 9
 * File: LostState.cs
 * Decription: If the player health goes zero a message will appear indicating the player is defeated.
 * */using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LostState : State
    {
        public LostState(BattleSystem system) : base(system)
        {
        }

        public override IEnumerator Start()
        {
            _system.HUD.SetDialogText("You were defeated.");
            yield break;
        }
    
}
