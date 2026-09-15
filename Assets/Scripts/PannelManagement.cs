using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PannelManagement : MonoBehaviour
{
    public GameObject MainPannel;
    public GameObject MakeDiary;

    public GameObject AddNewDiary;
    public GameObject Settings;
    public GameObject AchivementPannel;
    public GameObject CharacterPannel;

    public void ActiveMain()
    {
        MainPannel.SetActive(true);
        MakeDiary.SetActive(false);
        AddNewDiary.SetActive(false);
        Settings.SetActive(false);
        AchivementPannel.SetActive(false);
        CharacterPannel.SetActive(false);
    }

    public void ActiveMakeDiary()
    {
        MainPannel.SetActive(false);
        MakeDiary.SetActive(true);
        AddNewDiary.SetActive(false);
        Settings.SetActive(false);
        AchivementPannel.SetActive(false);
        CharacterPannel.SetActive(false);
    }

    public void ActiveAddNewDiary()
    {
        MainPannel.SetActive(false);
        MakeDiary.SetActive(false);
        AddNewDiary.SetActive(true);
        Settings.SetActive(false);
        AchivementPannel.SetActive(false);
        CharacterPannel.SetActive(false);
    }

    public void ActiveSettings()
    {
        MainPannel.SetActive(false);
        MakeDiary.SetActive(false);
        AddNewDiary.SetActive(false);
        Settings.SetActive(true);
        AchivementPannel.SetActive(false);
        CharacterPannel.SetActive(false);
    }

    public void ActiveAchivementPannel()
    {
        MainPannel.SetActive(false);
        MakeDiary.SetActive(false);
        AddNewDiary.SetActive(false);
        Settings.SetActive(false);
        AchivementPannel.SetActive(true);
        CharacterPannel.SetActive(false);
    }

    public void ActiveCharacterPannel() 
    {
        MainPannel.SetActive(false);
        MakeDiary.SetActive(false);
        AddNewDiary.SetActive(false);
        Settings.SetActive(false);
        AchivementPannel.SetActive(false);
        CharacterPannel.SetActive(true);
    }
}
