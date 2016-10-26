using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RestartScript : MonoBehaviour
{
    public void RestartLevel()
    {
        Application.LoadLevel(1);
       
    }
    public void MainMenu()
    {
        Application.LoadLevel(0);
        
    }
}