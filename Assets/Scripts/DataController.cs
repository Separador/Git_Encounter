using UnityEngine;
using System.IO;

public class DataController : MonoBehaviour
{
    private static string tiles_folder = "Tiles";

    public DataController() {
    }

    void SaveCardToJson(TileCard card) {
        string data_as_json = JsonUtility.ToJson(card);
        string file_path = Path.Combine(tiles_folder, card.id.ToString());
        string complete_path = Path.Combine(Application.dataPath, file_path);
        File.WriteAllText (complete_path, data_as_json);
    }

    private TileCard LoadCardFromJson(string name) {
            string file_path = Path.Combine(tiles_folder, name); 
            string complete_path = Path.Combine(Application.dataPath, file_path);
            TileCard tile_obj = new TileCard();
            if (File.Exists(complete_path))
            {
                string data_as_json = File.ReadAllText(complete_path);
                return JsonUtility.FromJson<TileCard>(data_as_json);
            }
            else
            {
                Debug.LogError("Cannot load game data!");
            }
            return tile_obj;
        }

    void Awake() {
        DataController dc = new DataController();
        TileCard tc = new TileCard();
        tc.name = "Check";
        Debug.Log(tc.id.ToString());
        dc.SaveCardToJson(tc);
        tc = new TileCard();
        Debug.Log(tc.id.ToString());
        tc = dc.LoadCardFromJson("1");
        Debug.Log(tc.name + tc.id.ToString());
    }
}