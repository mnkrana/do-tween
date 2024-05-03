using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace Tutorial.MovePath
{
    public class MoveOnPath : MonoBehaviour
    {
        [SerializeField] private List<Transform> targets;
        [SerializeField] private float duration;
        [SerializeField] private Ease ease;
        [SerializeField] private PathMode mode;
        [SerializeField] private PathType type;
        [SerializeField] private float lookAtVal;



        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Move();
            }
        }

        private void Move()
        {
            var wayPoint = new List<Vector3>();
            targets.ForEach(x => wayPoint.Add(x.position));
            transform.DOPath(wayPoint.ToArray(),
                            duration * wayPoint.Count,
                            type,
                            mode,
                            10,
                            Color.black)
                            .SetLookAt(lookAtVal).SetEase(ease).SetLoops(-1, LoopType.Restart);
        }
    }
}