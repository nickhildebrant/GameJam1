using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public void LoadLevel(string scene) {
        SceneManager.LoadScene(scene);
    }
}
