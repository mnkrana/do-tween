using DG.Tweening;
using UnityEngine;

namespace Tutorial.Why
{
    public class MoveEasy : MonoBehaviour
    {
        [SerializeField] private float duration;

        [SerializeField] private int loopValue;

        [SerializeField] private LoopType type;

        [SerializeField] private float yMax, yMin;



        void Start()
        {
            transform.DOMoveY(yMax, duration).
            SetLoops(loopValue, type);
        }
    }
}