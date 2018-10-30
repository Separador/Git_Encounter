using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Game_data
{
    // TODO: change GameObject to Encounter class    
    private Queue<GameObject> encounter_deck;
    // TODO: change GameObject to Treasure class    
    private Queue<GameObject> treasure_deck;
    // TODO: change GameObject to Monster class
    private Queue<GameObject> monster_deck;
    private int player_count;
    private int current_player;
    private int healing_count;
    public GamePhase Phase { set; get; }
    public int Turn { set; get; }
    public Game_data()
    {
        this.Phase = GamePhase.hero;
        this.Turn = 1;
    }
}

[System.Serializable]
public class TileCard
{
    public string name;
    public static uint count;
    public int id;
    public bool is_black;
    public uint square_count;
    public TileCard() {
        count++;
        id = count.GetHashCode();
    }
}