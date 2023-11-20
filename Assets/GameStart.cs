using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonChangeScene : MonoBehaviour
{
    public string sceneName = "level 1";

    // Обработчик события On Click
    public void OnButtonClick()
    {
        // Загружаем сцену с указанным именем
        SceneManager.LoadScene(sceneName);
    }
}
