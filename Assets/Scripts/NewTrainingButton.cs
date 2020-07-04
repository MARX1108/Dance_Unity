using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewTrainingButton : MonoBehaviour
{
    public GameObject theText;
    public GameObject thePanel;

    public GameObject newTrainingPanel;




    public void ClearText()
    {
        theText.GetComponent<InputField>().text = "";
    }
    public void CancelButton()
    {
        thePanel.SetActive(false);
    }
    public void OpenPanel()
    {
        thePanel.SetActive(true);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}

