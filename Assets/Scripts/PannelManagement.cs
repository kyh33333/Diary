using System.Collections;
using UnityEngine;

public class PanelAnimationController : MonoBehaviour
{
    public Animator effectAnimator; // 연출용 애니메이터
    public GameObject targetPanel;   // 열고자 하는 패널

    // 버튼 OnClick()에 이 함수를 연결
    public void OpenPanelWithDelay()
    {
        StartCoroutine(OpenPanelRoutine());
    }

    IEnumerator OpenPanelRoutine()
    {
        // 1. 연출 애니메이션 트리거 실행
        effectAnimator.SetTrigger("OpenEffect");

        // 2. 애니메이션 재생 시간만큼 대기 (예: 0.5초)
        yield return new WaitForSeconds(0.5f);

        // 3. 패널 활성화
        targetPanel.SetActive(true);
    }
}