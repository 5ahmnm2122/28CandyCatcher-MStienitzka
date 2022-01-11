using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveInfo : MonoBehaviour
{
    public Storage storageName;
    public InputField inputText;

    public void saveText(){
        storageName.playerName = inputText.text;
    }
}
