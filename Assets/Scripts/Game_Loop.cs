using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Game_Loop : loads initial game state and implements game loop logic:
// - controls turn order
// - controls transition between stages in turn
// - calls ui to update to match current game state
public class Game_Loop : MonoBehaviour
{
    private Board board;
    private Game_data game;
    public Text level_text;
    // Use this for initialization
    void Awake()
    {
        board = GetComponent<Board>();
        Debug.Log("Init game");
        InitGame();
        Debug.Log("Game started!");
    }

    // InitGame : game entry point on Awake;
    // loads scenario settings:
    // - calls tile deck
    // - encounter_deck;
    // - treasure_deck;
    // - monster_deck;
    // - healing count;
    // - set players;
    // sets up ui info;
    void InitGame()
    {
        game = new Game_data();
        board.InitBoard();
        SetGameText();
    }

    // sets level_text with current turn and stage info
    void SetGameText()
    {
        string p = "";

        switch (game.Phase)
        {
            case GamePhase.hero:
                p = "Hero Phase";
                break;
            case GamePhase.explore:
                p = "Exploration Phase";
                break;
            case GamePhase.villian:
                p = "Villian Phase";
                break;
        }
        level_text.text = string.Format("Turn: {0}, {1}", game.Turn, p);
    }
}