using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeScreenUIController : MonoBehaviour
{

    [SerializeField] GameObject A, B, C, D, E, F, G;

    // Start is called before the first frame update
    void Start()
    {
        A.SetActive(true);
        B.SetActive(true);
        C.SetActive(true);
        D.SetActive(false);
        E.SetActive(false);
        F.SetActive(true);
        G.SetActive(false);
    }

    public void Credits() {

        A.SetActive(false);
        B.SetActive(false);
        C.SetActive(false);
        D.SetActive(true);
        E.SetActive(true);
        F.SetActive(false); 
        G.SetActive(false);

    }

    public void Controls() {
        A.SetActive(false);
        B.SetActive(false);
        C.SetActive(false);
        D.SetActive(false);
        E.SetActive(true);
        F.SetActive(false);
        G.SetActive(true);
    }

    public void Back() {
        A.SetActive(true);
        B.SetActive(true);
        C.SetActive(true);
        D.SetActive(false);
        E.SetActive(false);
        F.SetActive(true);
        G.SetActive(false);
    }

    public void LevelOne() {
        SceneManager.LoadScene("Level1");
    }

    public void LevelTwo() {
        SceneManager.LoadScene("Level2");
    }

}
