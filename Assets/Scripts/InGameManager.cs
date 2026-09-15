using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // 씬 재로드 기능 추가
using TMPro;

public class InGameManager : MonoBehaviour
{
    public TMP_Text statusText;
    public TMP_Text eventTitleText;
    public TMP_Text eventBodyText;

    public TMP_Text choice1Text;
    public TMP_Text choice2Text;
    public TMP_Text choice3Text;

    public GameObject choice1Button;
    public GameObject choice2Button;
    public GameObject choice3Button;

    // 엔딩 UI 변수
    [Header("Ending UI Settings")]
    public GameObject endingPanel;      // EndingPanel 오브젝트 자체
    public Image endingImage;           // 엔딩 이미지 UI
    public TMP_Text endingTitleText;    // 엔딩 제목 텍스트
    public TMP_Text endingDescText;     // 엔딩 설명 텍스트
    public Sprite professorSprite;      // 교수 엔딩 이미지 (선택)
    public Sprite celebritySprite;      // 연예인 엔딩 이미지 (선택)
    public Sprite normalSprite;         // 일반 엔딩 이미지 (선택)

    // 시트 기반 주요 스탯 수치
    private string ageStage = "임신중";
    private int health = 50;       // 체력
    private int mental = 50;       // 멘탈/정신
    private int intelligence = 10; // 지력
    private int charm = 10;        // 매력
    private int money = 100000;    // 보유자산

    private int step = 0;

    void Start()
    {
        if (endingPanel != null) endingPanel.SetActive(false); // 시작 시 엔딩창 비활성화
        ShowStep(0);
    }

    private void UpdateUI()
    {
        if (statusText != null)
        {
            statusText.text = $"[{ageStage}] 체력:{health} | 멘탈:{mental} | 지력:{intelligence} | 매력:{charm} | 자산:{money:N0}원";
        }
    }

    private void ShowStep(int currentStep)
    {
        step = currentStep;

        switch (step)
        {
            case 0: // 오프닝
                ageStage = "임신중";
                eventTitleText.text = "오프닝: 일기의 시작";
                eventBodyText.text = "Diary에 오신 것을 환영합니다. \n \n 오늘부터 당신의 손에 한 아이의 삶이 맡겨졌습니다.\n아이가 무사히 어른이 되어 세상에 발을 내딛을 때까지, 당신은 이 일기를 기록해야 합니다. \n당신이 무너지는 순간 이 일기는 영원히 같은 페이지에 남게 될 것 입니다. 체력과 멘탈을 잘 관리하시길바랍니다.\n \n 자, 펜을 드세요. 이 아이의 첫 페이지가 시작됩니다.";

                SetChoice(1, "1. 펜을 잡는다 (시작)");
                SetChoice(2, null);
                SetChoice(3, null);
                break;

            case 1: // 인트로
                ageStage = "출산 직후";
                eventTitleText.text = "인트로: 아이의 온기";
                eventBodyText.text = "품 안의 아이는 생각보다 가벼웠지만, 그 온기는 선명했습니다. \n이제 이 작은 숨소리를 지키는 것은 온전히 당신의 몫입니다.\n\n아이의 시간은 이미 흐르기 시작했습니다.\n당신은 아이의 얼굴을 가만히 내려다보며, 일기장의 첫 줄을 고민합니다.";

                SetChoice(1, "1. 부족함 없이 키워줄게 (자산 상승)");
                SetChoice(2, "2. 건강하게만 자라다오 (체력 상승)");
                SetChoice(3, "3. 사랑하는 법을 배워갈게 (멘탈 상승)");
                break;

            case 2: // 신생아 고열 이벤트
                ageStage = "신생아";
                eventTitleText.text = "돌발 이벤트: 신생아 고열";
                eventBodyText.text = "갑자기 아이에게 39도가 넘는 고열이 나기 시작합니다!\n해열제를 먹여도 열이 쉽게 내리지 않고 아이는 지쳐서 끙끙 앓고 있습니다.";

                SetChoice(1, "1. 당장 아이를 들쳐업고 응급실로 뛰어간다. (자산 -10,000원)");
                SetChoice(2, "2. 미지근한 수건으로 몸을 닦아주며 밤새 곁을 지킨다. (체력-1, 멘탈-1)");
                SetChoice(3, null);
                break;

            case 3: // 첫 걸음마
                ageStage = "유아기";
                eventTitleText.text = "첫 걸음마";
                eventBodyText.text = "걸음마를 떼려다 자꾸 넘어지는 아이가 보입니다.";

                SetChoice(1, "1. 손을 잡아준다 (멘탈 +10)");
                SetChoice(2, "2. 스스로 일어서게 둔다 (지력 +10)");
                SetChoice(3, "3. 넘어지지 않게 안아준다 (체력 +10)");
                break;

            case 4: // 초등학생 입학식
                ageStage = "초등학생";
                eventTitleText.text = "입학식";
                eventBodyText.text = "낯선 학교 문 앞에 서서 불안해하는 아이.";

                SetChoice(1, "1. 학업의 중요성을 설명한다 (지력 +20)");
                SetChoice(2, "2. 친구들과 즐겁게 놀라 한다 (매력 +20)");
                SetChoice(3, "3. 고급 학원가를 알아본다 (자산 -30,000원)");
                break;

            case 5: // 엔딩 결과 화면
                ShowEnding();
                return;
        }

        UpdateUI();
    }

    public GameObject notePopup; // Inspector에서 NotePopup 오브젝트 연결

    public void OpenNotePopup()
    {
        if (notePopup != null) notePopup.SetActive(true);
    }

    public void CloseNotePopup()
    {
        if (notePopup != null) notePopup.SetActive(false);
    }

    private void SetChoice(int index, string text)
    {
        if (index == 1)
        {
            choice1Button.SetActive(text != null);
            if (text != null) choice1Text.text = text;
        }
        else if (index == 2)
        {
            choice2Button.SetActive(text != null);
            if (text != null) choice2Text.text = text;
        }
        else if (index == 3)
        {
            choice3Button.SetActive(text != null);
            if (text != null) choice3Text.text = text;
        }
    }

    // 엔딩 패널 팝업 띄우기
    private void ShowEnding()
    {
        ageStage = "성인 (독립)";

        if (endingPanel != null)
        {
            endingPanel.SetActive(true);

            if (intelligence >= 30)
            {
                if (endingTitleText) endingTitleText.text = "최종 엔딩: 교수/연구원";
                if (endingDescText) endingDescText.text = "아이는 높은 지성을 갖춘 '교수/연구원'으로 훌륭히 성장했습니다!\n훌륭한 양육이었습니다.";
                if (endingImage && professorSprite) endingImage.sprite = professorSprite;
            }
            else if (charm >= 30)
            {
                if (endingTitleText) endingTitleText.text = "최종 엔딩: 연예인/인플루언서";
                if (endingDescText) endingDescText.text = "아이는 뛰어난 매력을 발산하는 '연예인/인플루언서'가 되었습니다!\n아이의 앞날을 축복합니다.";
                if (endingImage && celebritySprite) endingImage.sprite = celebritySprite;
            }
            else
            {
                if (endingTitleText) endingTitleText.text = "최종 엔딩: 평범한 사회인";
                if (endingDescText) endingDescText.text = "아이는 따뜻한 마음을 가진 평범하고 행복한 사회인으로 성장했습니다!";
                if (endingImage && normalSprite) endingImage.sprite = normalSprite;
            }
        }

        UpdateUI();
    }

    // 씬 자체를 처음 상태로 완전히 다시 로드하는 쌩 리셋 기능
    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // 선택지 버튼 동작
    public void OnClickChoice1()
    {
        if (step == 0) ShowStep(1);
        else if (step == 1) { money += 50000; ShowStep(2); }
        else if (step == 2) { money -= 10000; ShowStep(3); }
        else if (step == 3) { mental += 10; ShowStep(4); }
        else if (step == 4) { intelligence += 20; ShowStep(5); }
    }

    public void OnClickChoice2()
    {
        if (step == 1) { health += 20; ShowStep(2); }
        else if (step == 2) { health -= 10; mental -= 10; ShowStep(3); }
        else if (step == 3) { intelligence += 10; ShowStep(4); }
        else if (step == 4) { charm += 20; ShowStep(5); }
    }

    public void OnClickChoice3()
    {
        if (step == 1) { mental += 20; ShowStep(2); }
        else if (step == 3) { health += 10; ShowStep(4); }
        else if (step == 4) { money -= 30000; ShowStep(5); }
    }
}