using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
   public Storage storageName;
   public void MainScene(){
   SceneManager.LoadScene("MainScene");
   }
    public void FirstScene()
    {
        SceneManager.LoadScene("Intro");
    }
}
