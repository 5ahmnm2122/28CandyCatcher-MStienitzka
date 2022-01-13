using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Storage infoStorage;
    public Text yourName;
    public Text yourScore;

    private void Start()
    {
        yourName.text = infoStorage.playerName;
        yourScore.text = infoStorage.score.ToString();
    }
}
