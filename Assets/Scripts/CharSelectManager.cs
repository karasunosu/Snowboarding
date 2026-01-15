using UnityEngine;

public class CharSelectManager : MonoBehaviour
{
    [SerializeField] GameObject scoreCanvas;
    [SerializeField] GameObject narutoSprite;
    [SerializeField] GameObject gojoSprite;

    void Start()
    {
        Time.timeScale = 0;
    }

    void Begin()
    {
        this.gameObject.SetActive(false);
        scoreCanvas.SetActive(true);
        Time.timeScale = 1f;
    }

    public void chooseNaruto()
    {
        narutoSprite.SetActive(true);
        Begin();
    }

    public void chooseGojo()
    {
        gojoSprite.SetActive(true);
        Begin();
    }
}
