using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace NSJ_EasyPoolKit
{
    public class PoolSpawner : MonoBehaviour
    {
        [SerializeField] private Button _getButton;
        [SerializeField] private Button _returnButton;

        [SerializeField] private SampleObject _samplePrefab;
        [SerializeField] private Vector3 _randomRange;


        private Queue<SampleObject> _sampleQueue = new Queue<SampleObject>();


        private void Start()
        {
            _getButton.onClick.AddListener(() => GetObject());
            _returnButton.onClick.AddListener(() => ReturnObject());
        }

        private void GetObject()
        {
            // Get Method
            SampleObject newObj = ObjectPool.Get(_samplePrefab, transform).OnDebug("GetPool Test");

            _sampleQueue.Enqueue(newObj);

            newObj.transform.position = GetRandomPos();
        }
        private void ReturnObject()
        {
            if (_sampleQueue.Count > 0)
            {
                SampleObject obj = _sampleQueue.Dequeue();

                // Return Method
                ObjectPool.Return(obj).OnDebug("ReturnPool Test");
            }
        }

        private Vector3 GetRandomPos()
        {
            Vector3 randomPos = new Vector3
                (
                transform.position.x + Random.Range(-_randomRange.x, _randomRange.x),
                transform.position.y + Random.Range(-_randomRange.y, _randomRange.y),
                transform.position.z + Random.Range(-_randomRange.z, _randomRange.z)
                );
            return randomPos;
        }

    }
}