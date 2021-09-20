using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeScreenUIController : MonoBehaviour
{

    [SerializeField] GameObject A, B, C, D, E;

    // Start is called before the first frame update
    void Start()
    {
        A.SetActive(true);
        B.SetActive(true);
        C.SetActive(true);
        D.SetActive(false);
        E.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Credits() {

        A.SetActive(false);
        B.SetActive(false);
        C.SetActive(false);
        D.SetActive(true);
        E.SetActive(true);

    }

    public void Back() {
        A.SetActive(true);
        B.SetActive(true);
        C.SetActive(true);
        D.SetActive(false);
        E.SetActive(false);
    }

    public void LevelOne() {
        SceneManager.LoadScene("Level1");
    }

    public void LevelTwo() {
        SceneManager.LoadScene("Level2");
    }

}
