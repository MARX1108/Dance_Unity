using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewTrainingButton : MonoBehaviour
{
    public GameObject theText;
    public GameObject thePanel;

    public GameObject MainPanel_1;
    public GameObject AddVideoPanel;

    public GameObject MainPanel_2;

    public GameObject FilePanel;
    public GameObject ResultPanel;
    // on start 
    void Start()
    {
        // MainPanel_1.SetActive(false);
        MainPanel_1.SetActive(false);
        AddVideoPanel.SetActive(false);
        MainPanel_2.SetActive(false);
    }



    public void openFP()
    {
        FilePanel.SetActive(true);
        ResultPanel.SetActive(false);
    }
    public void openRP()
    {
        FilePanel.SetActive(false);
        ResultPanel.SetActive(true);
    }
    //open main panel when click new Training
    public void OpenMp1()
    {
        MainPanel_1.SetActive(true);
    }

    //from mp1 to mp2 when click next button
    public void Mp1ToMp2()
    {
        MainPanel_1.SetActive(false);
        MainPanel_2.SetActive(true);
    }

    //from mp2 to mp1 when click back button
    public void Mp2ToMp1()
    {
        MainPanel_1.SetActive(true);
        MainPanel_2.SetActive(false);
    }
    

    public void Submit()
    {
        MainPanel_1.SetActive(false);
        MainPanel_2.SetActive(false);
    }

    // open the addnvideopanel
    public void OpenNewVideoPanel()
    {
        AddVideoPanel.SetActive(true);
    }
    // close the addnvideopanel
    public void CloseNewVideoPanel()
    {
        AddVideoPanel.SetActive(false);
    }
    // submit add new video
    public void AddNewVideo()
    {
        AddVideoPanel.SetActive(false);
        MainPanel_1.SetActive(true);
    }

    public void Close()
    {
        MainPanel_1.SetActive(false);
        AddVideoPanel.SetActive(false);
        MainPanel_2.SetActive(false);
    }

    

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

