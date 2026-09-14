using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PannelManagement : MonoBehaviour
{
    public GameObject MainPannel;
    public GameObject MakeDiary;

    public GameObject AddNewDiary;

    public void ActiveMain()
    {
        MainPannel.SetActive(true);
        MakeDiary.SetActive(false);
        AddNewDiary.SetActive(false);
    }

    public void ActiveMakeDiary()
    {
        MainPannel.SetActive(false);
        MakeDiary.SetActive(true);
        AddNewDiary.SetActive(false);
    }

    public void ActiveAddNewDiary()
    {
        MainPannel.SetActive(false);
        MakeDiary.SetActive(false);
        AddNewDiary.SetActive(true);
    }
}
