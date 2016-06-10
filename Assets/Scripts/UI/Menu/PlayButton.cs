using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{

    [SerializeField] private Image _playImage;
    [SerializeField] private Sprite _spriteOnClick;
    [SerializeField] private Sprite _spriteDefault;

    // Use this for initialization
    void Start()
    {
        _playImage.sprite = _spriteDefault;
    }

    void Update()
    {

    }

    public void PlayButtonClick(int scene)
    {
        StartCoroutine(Play(scene));
    }

    IEnumerator Play(int scene)
    {
        _playImage.sprite = _spriteOnClick;
        yield return new WaitForSeconds(.3f);
        SceneManager.LoadScene(scene);
    }
}
