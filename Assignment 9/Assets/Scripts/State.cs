/*
 * Name: George Tang
 * Project: Assignment 9
 * File: State.cs
 * Decription: abstract class for states
 * */
using System.Collections;
using UnityEngine;


public abstract class State
{
        protected readonly BattleSystem _system;

        public State(BattleSystem system)
        {
            _system = system;
        }
        
        public virtual IEnumerator Start()
        {
            yield break;
        }
        
        public virtual IEnumerator Attack()
        {
            yield break;
        }

        public virtual IEnumerator Heal()
        {
            yield break;
        }

        public virtual bool Restart()
        {
        return true;
        }

}
