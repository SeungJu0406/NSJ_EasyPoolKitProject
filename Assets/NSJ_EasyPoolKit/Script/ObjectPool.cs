using NSJ_EasyPoolKit;
using UnityEngine;

// �ּ��ދ� ����� �ѱ�� �Ѵ� �����


/// <summary>
///  ObjectPool Ŭ������ ���� ������Ʈ Ǯ���� �����ϴ� ��ƿ��Ƽ Ŭ�����Դϴ�.
///  The ObjectPool class is a utility class for managing game object pooling.
/// </summary>
public static class ObjectPool
{
    private static IObjectPool s_objectPool;

    /// <summary>
    /// Sets the object pool to be used for managing reusable objects.
    /// Ǯ�� �����մϴ�. �� �޼���� �ܺο��� ȣ���Ͽ� ����� ���� Ǯ�� ������ �� �ֽ��ϴ�.
    /// </summary>
    public static void SetPool(IObjectPool pool)
    {
        s_objectPool = pool;
    }

    /// <summary>
    /// ������Ʈ�� �����ɴϴ�.
    /// Gets an objects from the pool.
    /// </summary>
    /// <param name="prefab"></param>
    /// <returns></returns>
    public static GameObject Get(GameObject prefab)
    {
        CreatePool();
        return s_objectPool.Get(prefab);
    }

    /// <summary>
    /// ������Ʈ�� �����ɴϴ�. Ʈ�������� ������ �� �ֽ��ϴ�.
    /// Gets an object from the pool with a specified transform.
    /// </summary>
    /// <param name="prefab"></param>
    /// <param name="transform"></param>
    /// <param name="worldPositionStay"></param>
    /// <returns></returns>
    public static GameObject Get(GameObject prefab, Transform transform, bool worldPositionStay = default)
    {
        CreatePool();
        return s_objectPool.Get(prefab, transform, worldPositionStay);
    }
    /// <summary>
    /// ������Ʈ�� �����ɴϴ�. ��ġ�� ȸ���� ������ �� �ֽ��ϴ�.
    /// Gets an object from the pool with a specified position and rotation.
    /// </summary>
    /// <param name="prefab"></param>
    /// <param name="pos"></param>
    /// <param name="rot"></param>
    /// <returns></returns>
    public static GameObject Get(GameObject prefab, Vector3 pos, Quaternion rot)
    {
        CreatePool();
        return s_objectPool.Get(prefab, pos, rot);
    }
    /// <summary>
    /// ������Ʈ�� �����ɴϴ�. ������Ʈ�� ��ȯ�մϴ�.
    /// Gets an object from the pool and returns a component of type T.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="prefab"></param>
    /// <returns></returns>
    public static T Get<T>(T prefab) where T : Component
    {
        CreatePool();
        return s_objectPool.Get(prefab);
    }
    /// <summary>
    /// ������Ʈ�� �����ɴϴ�. ������Ʈ�� ��ȯ�մϴ�. Ʈ�������� ������ �� �ֽ��ϴ�.
    /// Get an object from the pool and returns a component of type T with a specified transform.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="prefab"></param>
    /// <param name="transform"></param>
    /// <param name="worldPositionStay"></param>
    /// <returns></returns>
    public static T Get<T>(T prefab, Transform transform, bool worldPositionStay = default) where T : Component
    {
        CreatePool();
        return s_objectPool.Get(prefab, transform, worldPositionStay);
    }
    /// <summary>
    /// ������Ʈ�� �����ɴϴ�. ������Ʈ�� ��ȯ�մϴ�. ��ġ�� ȸ���� ������ �� �ֽ��ϴ�.
    ///  Get an object from the pool and returns a component of type T with a specified position and rotation.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="prefab"></param>
    /// <param name="pos"></param>
    /// <param name="rot"></param>
    /// <returns></returns>
    public static T Get<T>(T prefab, Vector3 pos, Quaternion rot) where T : Component
    {
        CreatePool();
        return s_objectPool.Get(prefab, pos, rot);
    }
    /// <summary>
    /// ������Ʈ�� Resources���� �����ɴϴ�.
    /// Get an object from Resources.
    /// </summary>
    /// <param name="resouces"></param>
    /// <returns></returns>
    public static GameObject ResourcesGet(string resouces)
    {
        CreatePool();
        return s_objectPool.ResourcesGet(resouces);
    }
    /// <summary>
    /// ������Ʈ�� Resources���� �����ɴϴ�. Ʈ�������� ������ �� �ֽ��ϴ�.
    ///  Get an object from Resources with a specified transform.
    /// </summary>
    /// <param name="resouces"></param>
    /// <param name="transform"></param>
    /// <param name="worldPositionStay"></param>
    /// <returns></returns>
    public static GameObject ResourcesGet(string resouces, Transform transform, bool worldPositionStay = default)
    {
        CreatePool();
        return s_objectPool.ResourcesGet(resouces, transform, worldPositionStay);
    }
    /// <summary>
    /// ������Ʈ�� Resources���� �����ɴϴ�. ��ġ�� ȸ���� ������ �� �ֽ��ϴ�.
    /// Get an object from Resources with a specified position and rotation.
    /// </summary>
    /// <param name="resouces"></param>
    /// <param name="pos"></param>
    /// <param name="rot"></param>
    /// <returns></returns>
    public static GameObject ResourcesGet(string resouces, Vector3 pos, Quaternion rot)
    {
        CreatePool();
        return s_objectPool.ResourcesGet(resouces, pos, rot);
    }
    /// <summary>
    /// ������Ʈ�� Resources���� �����ɴϴ�. ������Ʈ�� ��ȯ�մϴ�.
    /// Get an object from Resources and returns a component of type T.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="resouces"></param>
    /// <returns></returns>
    public static T ResourcesGet<T>(string resouces) where T : Component
    {
        CreatePool();
        return s_objectPool.ResourcesGet<T>(resouces);
    }
    /// <summary>
    /// ������Ʈ�� Resources���� �����ɴϴ�. ������Ʈ�� ��ȯ�մϴ�. Ʈ�������� ������ �� �ֽ��ϴ�.
    /// Get an object from Resources and returns a component of type T with a specified transform.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="resouces"></param>
    /// <param name="transform"></param>
    /// <param name="worldPositionStay"></param>
    /// <returns></returns>
    public static T ResourcesGet<T>(string resouces, Transform transform, bool worldPositionStay = default) where T : Component
    {
        CreatePool();
        return s_objectPool.ResourcesGet<T>(resouces, transform, worldPositionStay);
    }
    /// <summary>
    /// ������Ʈ�� Resources���� �����ɴϴ�. ������Ʈ�� ��ȯ�մϴ�. ��ġ�� ȸ���� ������ �� �ֽ��ϴ�.
    /// Get an object from Resources and returns a component of type T with a specified position and rotation.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="resouces"></param>
    /// <param name="pos"></param>
    /// <param name="rot"></param>
    /// <returns></returns>
    public static T ResourcesGet<T>(string resouces, Vector3 pos, Quaternion rot) where T : Component
    {
        CreatePool();
        return s_objectPool.ResourcesGet<T>(resouces, pos, rot);
    }
    /// <summary>
    /// ������Ʈ�� ��ȯ�մϴ�.
    /// objects are returned to the pool.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public static IPoolInfoReadOnly Return(GameObject instance)
    {
        CreatePool();
        return s_objectPool.Return(instance);
    }
    /// <summary>
    /// ������Ʈ�� ��ȯ�մϴ�.
    /// objects are returned to the pool.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="instance"></param>
    /// <returns></returns>
    public static IPoolInfoReadOnly Return<T>(T instance) where T : Component
    {
        CreatePool();
        return s_objectPool.Return(instance);
    }
    /// <summary>
    /// ������Ʈ�� ��ȯ�մϴ�. ���� �ð��� ������ �� �ֽ��ϴ�.
    /// objects are returned to the pool with a specified delay.
    /// </summary>
    /// <param name="instance"></param>
    /// <param name="delay"></param>
    public static void Return(GameObject instance, float delay)
    {
        CreatePool();
        s_objectPool.Return(instance, delay);
    }
    /// <summary>
    /// ������Ʈ�� ��ȯ�մϴ�. ���� �ð��� ������ �� �ֽ��ϴ�.
    /// objects are returned to the pool with a specified delay.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="instance"></param>
    /// <param name="delay"></param>
    public static void Return<T>(T instance, float delay) where T : Component
    {
        CreatePool();
        s_objectPool.Return(instance, delay);
    }

    private static void CreatePool()
    {
        if (s_objectPool == null)
        {
            s_objectPool = EasyObjectPool.CreatePool();
        }
    }
}
