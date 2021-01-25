using UnityEngine;

public class GameOverDetector : MonoBehaviour
{
    public GameController gameController;

    public void GameOver()
    {
            gameController.SelectGameOverDescription();
    }
}
