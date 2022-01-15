using UnityEngine;

[CreateAssetMenu(fileName = "Storage", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 0)]
public class Storage : ScriptableObject {

    public string playerName;
    public int score;
    public float time;
    public int lives;
    public int size;
}