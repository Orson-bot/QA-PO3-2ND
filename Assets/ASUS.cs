using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ASUS : MonoBehaviour
{
    [SerializeField] Swordsman swordsman;
    [SerializeField] Archer archer;
    [SerializeField] Mage mage;
    [SerializeField] AssistantKnight knight;
    [SerializeField] DemonKing king;

    public Texture ButtonImage;
    
    private string Protagonist = "Choose your Character";
    private string Assistant = "The Companion is Here";
    private string Demon = "Demon King Incoming!";
    private string WinCondition = "War";
    private USER Player;
    private void OnGUI()
    {
        var FontSize = 40;
        UnityEngine.GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "2nd QA");

        UnityEngine.GUI.Label(new Rect(250, 75, 1000, 1000), Protagonist);

        UnityEngine.GUI.Label(new Rect(250, 500, 1000, 1000), Assistant);

        UnityEngine.GUI.Label(new Rect(1000, 200, 1000, 1000), Demon);

        UnityEngine.GUI.Label(new Rect(690, 350, 500, 100), WinCondition);

        UnityEngine.GUI.skin.label.fontSize = FontSize;

        if (UnityEngine.GUI.Button(new Rect(720, 100, 270, 220), ButtonImage))
        {
            
        }

        if (UnityEngine.GUI.Button(new Rect(25, 45, 150, 50), "Swordsman"))
        {
            Player = swordsman;
            Stats();
        }

        if (UnityEngine.GUI.Button(new Rect(25, 200, 150, 50), "Archer"))
        {
            Player = archer;
            Stats();
        }

        if (UnityEngine.GUI.Button(new Rect(25, 375, 150, 50), "Mage"))
        {
            Player = mage;
            Stats();
        }

        if (UnityEngine.GUI.Button(new Rect(25, 500, 150, 50), "Assistant Knight"))
        {
            knightStats();
        }

        if (UnityEngine.GUI.Button(new Rect(1250, 350, 150, 50), "Demon King"))
        {
          Demon = "Demon King: " + "\nHealth: " + king.Healthbar + "\nAttack: " + king.Attackbar + "\nDefences: " + king.Defences;
        }

        if (UnityEngine.GUI.Button(new Rect(1050, 500, 150, 50), "LABAN NA BOIIII!"))
        {
            if (king != null)
            {
                king.Healthbar -= Player.Attackbar;
            }

            if (Player != null)
            {
                Player.Healthbar -= king.Attackbar;
            }
            Stats();
            DemonStats();

            if (king.Healthbar <= 0)
            {
                WinCondition = " this is YOU!";
            }

            if (Player.Healthbar <= 0)
            {

                WinCondition = "You WIN!";
            }
        }
        

        
    }
    public void Stats()
    {
       Protagonist = "Player: " + "\nHealthbar: " + Player.Healthbar + "\nAttackbar: " + Player.Attackbar + "\nDefences: " + Player.Defences;

    }

    public void knightStats()
    {
        Assistant = "Player: " + "\nHealthbar: " + knight.Healthbar + "\nAttackbar: " + knight.Attackbar + "\nDefences: " + knight.Defences;

    }
    public void DemonStats()
    {
        Demon = "Player: " + "\nHealthbar: " + king.Healthbar + "\nAttackbar: " + king.Attackbar + "\nDefences: " + king.Defences;

    }
}