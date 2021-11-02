using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // Загрузить определенную сцену

    public void LoadSceneButton() => SceneManager.LoadScene("Sample Scene");
}
