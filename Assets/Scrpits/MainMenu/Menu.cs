using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }

    public void ResetLeaderBoard()
    {
        var scoreManager = FindObjectOfType<ScoreManager>();
        scoreManager.ResetRecords();
    }
}
