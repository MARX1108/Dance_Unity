using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewTrainingButton : MonoBehaviour
{
    public GameObject theText;
    public GameObject thePanel;

    public GameObject MainPanel_1;
    public GameObject TP_Close_button;

    public GameObject panel_step2;
    public GameObject new_video_panel;

    public GameObject main_panel_2;

    void Start()
    {
        MainPanel_1.SetActive(false);
        panel_step2.SetActive(false);
        new_video_panel.SetActive(false);
        main_panel_2.SetActive(false);
    }

    public void Back_2to1()
    {
        panel_step2.SetActive(false);
        MainPanel_1.SetActive(true);
    }

    public void Back_3to2()
    {
        panel_step2.SetActive(true);
        main_panel_2.SetActive(false);
    }



    public void Next_1to2()
    {
        panel_step2.SetActive(true);
        MainPanel_1.SetActive(false);
    }

    public void Next_2to3()
    {
        panel_step2.SetActive(false);
        main_panel_2.SetActive(true);
    }

    public void Submit()
    {
        MainPanel_1.SetActive(false);
        panel_step2.SetActive(false);
        new_video_panel.SetActive(false);
        main_panel_2.SetActive(false);

    }

    public void OpenNewVideoPanel()
    {
        new_video_panel.SetActive(true);
    }

    public void CloseNewVideoPanel()
    {
        new_video_panel.SetActive(false);
    }

    public void Close()
    {
        MainPanel_1.SetActive(false);
        panel_step2.SetActive(false);
        new_video_panel.SetActive(false);
        main_panel_2.SetActive(false);
    }

    public void AddNewVideo()
    {
        new_video_panel.SetActive(false);
        panel_step2.SetActive(true);
    }


    public void OpenNewMainPanel_1()
    {
        MainPanel_1.SetActive(true);
    }

    public void CloseNewMainPanel_1()
    {
        MainPanel_1.SetActive(false);
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

