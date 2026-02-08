using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Selection_page");
    }
    public void Coloring_Scene()
    {
        SceneManager.LoadScene("Play_Scene");
    }
    public void Tracing_Scene()
    {
        SceneManager.LoadScene("Tracing_Scene");
    }
    public void Animation_Scene()
    {
        SceneManager.LoadScene("Animation_Scene");
    }
    public void Exit_Scene()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void Exit_SceneToSelection()
    {
        SceneManager.LoadScene("Selection_page");
    }
}
