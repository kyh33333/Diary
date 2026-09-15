using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PannelManagement : MonoBehaviour
{
    public Animator effectAnimator;

    public GameObject MainPannel;
    public GameObject MakeDiary;

    public GameObject AddNewDiary;
    public GameObject Settings;
    public GameObject AchivementPannel;
    public GameObject CharacterPannel;

    public GameObject AddFeatureDiary;

    private IEnumerator PlayAnim()
    {
        if (effectAnimator != null)
        {
            effectAnimator.SetTrigger("OpenEffect");
        }
        yield return new WaitForSeconds(1.0f);
    }

    public void ActiveMain() => StartCoroutine(ActiveMainRoutine());
    private IEnumerator ActiveMainRoutine()
    {
        yield return PlayAnim();
        MainPannel.SetActive(true);
        MakeDiary.SetActive(false);
        AddNewDiary.SetActive(false);
        Settings.SetActive(false);
        AchivementPannel.SetActive(false);
        CharacterPannel.SetActive(false);
        AddFeatureDiary.SetActive(false);
    }

    public void ActiveMakeDiary() => StartCoroutine(ActiveMakeDiaryRoutine());
    private IEnumerator ActiveMakeDiaryRoutine()
    {
        yield return PlayAnim();
        MainPannel.SetActive(false);
        MakeDiary.SetActive(true);
        AddNewDiary.SetActive(false);
        Settings.SetActive(false);
        AchivementPannel.SetActive(false);
        CharacterPannel.SetActive(false);
        AddFeatureDiary.SetActive(false);
    }

    public void ActiveAddNewDiary() => StartCoroutine(ActiveAddNewDiaryRoutine());
    private IEnumerator ActiveAddNewDiaryRoutine()
    {
        yield return PlayAnim();
        MainPannel.SetActive(false);
        MakeDiary.SetActive(false);
        AddNewDiary.SetActive(true);
        Settings.SetActive(false);
        AchivementPannel.SetActive(false);
        CharacterPannel.SetActive(false);
        AddFeatureDiary.SetActive(false);
    }

    public void ActiveSettings() => StartCoroutine(ActiveSettingsRoutine());
    private IEnumerator ActiveSettingsRoutine()
    {
        yield return PlayAnim();
        MainPannel.SetActive(false);
        MakeDiary.SetActive(false);
        AddNewDiary.SetActive(false);
        Settings.SetActive(true);
        AchivementPannel.SetActive(false);
        CharacterPannel.SetActive(false);
        AddFeatureDiary.SetActive(false);
    }

    public void ActiveAchivementPannel() => StartCoroutine(ActiveAchivementPannelRoutine());
    private IEnumerator ActiveAchivementPannelRoutine()
    {
        yield return PlayAnim();
        MainPannel.SetActive(false);
        MakeDiary.SetActive(false);
        AddNewDiary.SetActive(false);
        Settings.SetActive(false);
        AchivementPannel.SetActive(true);
        CharacterPannel.SetActive(false);
        AddFeatureDiary.SetActive(false);
    }

    public void ActiveCharacterPannel() => StartCoroutine(ActiveCharacterPannelRoutine());
    private IEnumerator ActiveCharacterPannelRoutine()
    {
        yield return PlayAnim();
        MainPannel.SetActive(false);
        MakeDiary.SetActive(false);
        AddNewDiary.SetActive(false);
        Settings.SetActive(false);
        AchivementPannel.SetActive(false);
        CharacterPannel.SetActive(true);
        AddFeatureDiary.SetActive(false);
    }

    public void ActiveAddFeatureDiary() => StartCoroutine(ActiveAddFeatureDiaryRoutine());
    private IEnumerator ActiveAddFeatureDiaryRoutine()
    {
        yield return PlayAnim();
        MainPannel.SetActive(false);
        MakeDiary.SetActive(false);
        AddNewDiary.SetActive(false);
        Settings.SetActive(false);
        AchivementPannel.SetActive(false);
        CharacterPannel.SetActive(false);
        AddFeatureDiary.SetActive(true);
    }
}