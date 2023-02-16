using System;
using DG.Tweening;
using UnityEngine;

public class MainScene : MonoBehaviour
{
    [SerializeField] private CanvasGroup _frameImage;

    private void Start()
    {
        _frameImage.alpha = 1f;
        _frameImage.DOFade(0f, 1f);
    }
}