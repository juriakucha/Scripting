using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
  public string sceneName = "Level_1";

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(sceneName);    
    }

    
    
    
        
    
}
