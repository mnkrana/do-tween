using DG.Tweening;
using UnityEngine;

namespace Tutorial.Basics
{
    public class Scale : MonoBehaviour
    {
        [SerializeField] private float duration;
        [SerializeField] private Vector3 scale;
        [SerializeField] private Ease ease;

        void Start()
        {
            transform.DOScale(scale, duration).SetEase(ease).SetLoops(-1, LoopType.Yoyo);
        }
    }
}