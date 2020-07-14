using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewTrainingButton : MonoBehaviour
{
    public GameObject theText;
    public GameObject thePanel;

    public GameObject TrainingPanel;
    public GameObject TP_Close_button;

    public GameObject panel_step2;
    public GameObject new_video_panel;
    public GameObject back_2to1_button;
    public GameObject next_1to2_button;
    public GameObject next_2to3_button;
    public GameObject close_new_video_panel_button;
    public GameObject add_new_video_button;

    public GameObject step3_panel;
    public GameObject close_step3_panel;
    public GameObject submit_bt;


    void Start()
    {
        TrainingPanel.SetActive(false);
        panel_step2.SetActive(false);
        new_video_panel.SetActive(false);
        step3_panel.SetActive(false);
    }

    public void Back_2to1()
    {
        panel_step2.SetActive(false);
        TrainingPanel.SetActive(true);
    }

    public void Back_3to2()
    {
        panel_step2.SetActive(true);
        step3_panel.SetActive(false);
    }



    public void Next_1to2()
    {
        panel_step2.SetActive(true);
        TrainingPanel.SetActive(false);
    }

    public void Next_2to3()
    {
        panel_step2.SetActive(false);
        step3_panel.SetActive(true);
    }

    public void Submit()
    {
        TrainingPanel.SetActive(false);
        panel_step2.SetActive(false);
        new_video_panel.SetActive(false);
        step3_panel.SetActive(false);

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
        TrainingPanel.SetActive(false);
        panel_step2.SetActive(false);
        new_video_panel.SetActive(false);
        step3_panel.SetActive(false);
    }

    public void AddNewVideo()
    {
        new_video_panel.SetActive(false);
        panel_step2.SetActive(true);
    }


    public void OpenNewTrainingPanel()
    {
        TrainingPanel.SetActive(true);
    }

    public void CloseNewTrainingPanel()
    {
        TrainingPanel.SetActive(false);
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

