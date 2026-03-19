using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderScene : MonoBehaviour
{
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
