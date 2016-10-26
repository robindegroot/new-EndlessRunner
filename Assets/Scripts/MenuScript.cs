using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour
{

    public Canvas quitMenu;
    public Canvas instructionMenu;
    public Button startText;
    public Button instructionText;
    public Button exitText;

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 0;
        quitMenu = quitMenu.GetComponent<Canvas>();
        instructionMenu = instructionMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        instructionText = instructionText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        quitMenu.enabled = false;
        instructionMenu.enabled = false;

    }

    public void ExitPress()
    {
        quitMenu.enabled = true;
        instructionMenu.enabled = false;
        startText.enabled = false;
        instructionText.enabled = false;
        exitText.enabled = false;

    }

    public void NoPress()
    {
        quitMenu.enabled = false;
        instructionMenu.enabled = false;
        startText.enabled = true;
        instructionText.enabled = true;
        exitText.enabled = true;    }

    public void Instructions()
    {
        quitMenu.enabled = false;
        instructionMenu.enabled = true;
        startText.enabled = false;
        instructionText.enabled = false;
        exitText.enabled = false;
    }

    public void GoBack()
    {
        quitMenu.enabled = false;
        instructionMenu.enabled = false;
        startText.enabled = true;
        instructionText.enabled = true;
        exitText.enabled = true;
    }

    public void StartLevel()
    {
        Application.LoadLevel(1);
        Time.timeScale = 1;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}