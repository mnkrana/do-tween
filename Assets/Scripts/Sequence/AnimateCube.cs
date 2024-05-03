using DG.Tweening;
using UnityEngine;

namespace Tutorial.AnimateCube
{
    public class AnimateCube : MonoBehaviour
    {

        void Start()
        {
            StartSequence();
        }

        void StartSequence()
        {
            var seq = DOTween.Sequence();

            seq.Append(transform.DOLocalMoveY(4, 1));
            seq.Append(transform.DORotate(Vector3.one * 90, 1));            
            seq.Append(transform.DORotate(Vector3.zero, 1));            
            seq.Append(transform.DOLocalMoveY(0, 1));
            seq.OnComplete(StartSequence);
        }

    }
}