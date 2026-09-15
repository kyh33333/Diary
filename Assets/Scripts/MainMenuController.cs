using UnityEngine;
using UnityEngine.SceneManagement; // 씬 관리용 필수 네임스페이스

public class MainMenuController : MonoBehaviour
{
    // 버튼 OnClick()에 연결할 함수
    public void GoToInGame()
    {
        SceneManager.LoadScene("InGameScene");
    }
}