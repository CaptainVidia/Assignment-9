/*
 * Name: George Tang
 * Project: Assignment 9
 * File: HUD.cs
 * Decription: allows to store information through a dialog text with visuals.
 * */
using UnityEngine;
using UnityEngine.UI;


    public class HUD : MonoBehaviour
    {
        [SerializeField] private UnitHUD playerHUD;
        [SerializeField] private UnitHUD enemyHUD;
        [SerializeField] private Text dialogText;
        

        public void Initialize(Unit playerUnit, Unit enemyUnit)
        {
            playerHUD.Initialize(playerUnit);
            enemyHUD.Initialize(enemyUnit);
        }

        public void SetDialogText(string text)
        {
            dialogText.text = text;
        }
    }

