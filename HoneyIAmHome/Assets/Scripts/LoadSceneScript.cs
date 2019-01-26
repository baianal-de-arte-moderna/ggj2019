using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneScript: MonoBehaviour {
    public void LoadLevel()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Exit() {
        Application.Quit();
    }
}