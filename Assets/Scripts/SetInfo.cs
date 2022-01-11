using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetInfo : MonoBehaviour
{
    public Storage storageName;
    public Text playernamePreview;
    // Start is called before the first frame update
    void Start()
    {
        playernamePreview.text = storageName.playerName;    
    }

}
