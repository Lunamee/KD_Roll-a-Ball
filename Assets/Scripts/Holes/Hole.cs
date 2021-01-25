using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hole : MonoBehaviour
{
    bool isHolding;
    public bool destroyedPlayer;
    int counter;
    public FallArea fallArea;
    public GameOverDetector gameOverDetector;

    public bool IsHolding()
    {
        return isHolding;
    }
    public bool DestroyedPlayer()
    {
        return destroyedPlayer;
    }

    private void OnTriggerStay(Collider other)
    {
        if (fallArea.FallPlayer())
        {
            if (other.gameObject.CompareTag("Player"))
            {
                isHolding = true;
                destroyedPlayer = true;

                Destroy(other);
                gameOverDetector.GameOver();
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isHolding = false;
        }
    }
}
