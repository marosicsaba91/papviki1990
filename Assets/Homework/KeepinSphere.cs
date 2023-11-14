using UnityEngine;

class KeepinSphere : MonoBehaviour
{
    [SerializeField] Vector3 sphereCenter;
    [SerializeField] float sphereRadius = 5;

    void Update()
    {
        Vector3 selfPoint = transform.position;
        Vector3 distanceVec = selfPoint - sphereCenter;
        float distance = distanceVec.magnitude;


        bool isOut = selfPoint.magnitude > sphereRadius;

        if (isOut)
        {
            Vector3 offset = distanceVec.normalized * sphereRadius;
            transform.position = sphereCenter + offset;

            // Visszatesz
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(sphereCenter, sphereRadius);
    }
}
