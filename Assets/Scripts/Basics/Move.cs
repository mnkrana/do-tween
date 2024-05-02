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
            // MoveToNext();
            transform.DORotate(new Vector3(0,90,0), duration);
        }

        void MoveToNext()
        {
            ++_targetIndex;
            if(_targetIndex == targets.Count)
            {
                 _targetIndex = 0;
            }
            
            transform.DOMove(targets[_targetIndex].position, duration).SetEase(ease).OnComplete(MoveToNext);
        }
    }
}