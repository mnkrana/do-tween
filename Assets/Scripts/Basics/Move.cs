using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace Tutorial.Basics
{
    public class Move : MonoBehaviour
    {
        [SerializeField] private List<Transform> targets;        
        [SerializeField] private float duration;
        [SerializeField] private Ease ease;

        private int _targetIndex = -1;
        
        void Start()
        {
            MoveToNext();            
        }

        void MoveToNext()
        {
            ++_targetIndex;
            if(_targetIndex == targets.Count)
            {
                 _targetIndex = 0;
            }
            
            var seq = DOTween.Sequence();
            seq.Append(transform.DOLookAt(targets[_targetIndex].position, duration));
            seq.Append(transform.DOMove(targets[_targetIndex].position, duration).SetEase(ease));
            seq.OnComplete(MoveToNext);
        }
    }
}