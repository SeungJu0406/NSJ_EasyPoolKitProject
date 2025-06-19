using UnityEngine;

namespace NSJ_EasyPoolKit
{
    public class SampleObject : MonoBehaviour, IPooledObject
    {
        public void InitPooledObject()
        {
            Debug.Log($"{name} : PooledObject Initialize");
        }
    }
}