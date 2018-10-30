using UnityEngine;

public class Tile : MonoBehaviour
{
    private static int count;
    private int id;
    private string tile_name;
    // 4 element array; 0 - top, 1 - right, 2 - bot, 3 - left
    private GameObject[] adjacent = new GameObject[4];
    // 9 element array;
    // 0 1 2
    // 3 4 5
    // 6 7 8
    //private GameObject[] squares = new GameObject[9];

    public void InitTile(string name = "", GameObject[] adjTiles = null)
    {
        ++count;
        // id = count;
        tile_name = name;
        // GetTileInfo();
        if (adjTiles != null)
            for (int i = 0; i < adjTiles.Length; ++i)
            {
                if (adjTiles[i] == null)
                    continue;
                adjacent[i] = adjTiles[i];
            }
    }

    public void GetTileInfo()
    {
        // Debug.Log("Tile.GetTileInfo");
        Debug.Log("Tile.Count: " + count + "\t Tile ID: " + this.id + "\t Tile Name: " + this.tile_name);
    }

    void AddSquare()
    {

    }
}
