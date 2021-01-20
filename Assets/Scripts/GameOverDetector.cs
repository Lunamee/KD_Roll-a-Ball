using UnityEngine;

public class GameOverDetector : MonoBehaviour
{
    public Hole hole;
    public GameController gameController;

    // AudioSource gameOverSound;
    public AudioClip SE;

    private void Start()
    {
        // gameOverSound = GetComponent<AudioSource>();
    }
    public void GameOver()
    {
        // gameOverSound.Play();
        this.GetComponent<AudioSource>().PlayOneShot(SE);
        //if (hole.IsHolding())
        //{
            gameController.SelectGameOverDescription();
        //}
    }
}
