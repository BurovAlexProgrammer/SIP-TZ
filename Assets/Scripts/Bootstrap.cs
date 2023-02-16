using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private CanvasGroup _frameImage;
    
    void Start()
    {
        _frameImage.alpha = 1f;
        DOTween.Sequence()
            .Append(_frameImage.DOFade(0f, 1f))
            .AppendInterval(1.5f)
            .Append(_frameImage.DOFade(1f, 1f))
            .OnComplete(() => SceneManager.LoadScene(Scenes.MAIN));
    }
}
