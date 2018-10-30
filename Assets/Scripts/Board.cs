using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Board : implements board management logic:
// - loads tile deck
// - places tiles across the board
// - manages objects' positions across the board
public class Board : MonoBehaviour
{
    //object in scene hierachy where tiles are loaded
    public GameObject game_board;
    private Stack<GameObject> tile_deck;
    private GameObject current_tile;
    public int square_size = 1; //1 unity units;
    public int tile_size = 4;

    // sets up board initial state:
    // - sets up tile deck
    // - places initial game tile
    public void InitBoard()
    {
        //Load scenario info
        //Set up tile deck
        // tileDeck = new Stack<GameObject>();
        // tileDeck.Push();
        //Place start tile
        GameObject p1 = Resources.Load("Prefabs/Start_Tile1") as GameObject;
        GameObject p2 = Resources.Load("Prefabs/Start_Tile2") as GameObject;
        if (p1 && p2)
            PlaceStartTile(p1, p2);
        else
            Debug.Log("No start tiles to load");
        // current = p1;
        //p1.GetComponent<MyTile>().GetTileInfo();
        //p2.GetComponent<MyTile>().GetTileInfo();
        // GameObject p3 = Resources.Load("Prefabs/Start_Tile2") as GameObject;
    }
    void PlaceStartTile(GameObject part1, GameObject part2)
    {
        Instantiate(part1, new Vector3(0, 0, 0), Quaternion.identity, game_board.transform);
        Instantiate(part2, new Vector3(0, 0, tile_size), Quaternion.identity, game_board.transform);
        MyTile tile_p1 = part1.GetComponent<MyTile>();
        MyTile tile_p2 = part2.GetComponent<MyTile>();

        //tile_p1.InitTile("1");
        //tile_p2.InitTile("2", new GameObject[4] { null, null, part1, null });
    }
    //adds tile in specified direction to current tile;
    //direction - 
    void AddTile(Direction dir)
    {

    }
}