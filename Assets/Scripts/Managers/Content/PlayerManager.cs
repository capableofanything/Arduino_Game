using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerManager
{
    private Player currentPlayer;
    private bool alive = true;
    public void SetPlayer(Player player) { this.currentPlayer = player; Init(); }
    public void Init() { this.alive = true; }
    public int GetCurrentHP() { return this.currentPlayer.GetCurrentHP(); }
    public void HealCurrentHP() { this.currentPlayer.HealCurrentHP(); }
    public void DamageCurrentHP() { this.currentPlayer.DamageCurrentHP(); }
    public bool IsAlive() { return alive; }
    public void SetAlive(bool alive) { this.alive = alive; }
}
