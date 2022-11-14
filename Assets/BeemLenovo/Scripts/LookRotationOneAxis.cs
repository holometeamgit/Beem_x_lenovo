using UnityEngine;

public class LookRotationOneAxis : MonoBehaviour
{
    public Transform LookTarget;
    [SerializeField] private float _damping = 15.0f;
    [SerializeField] private float _lerpFactorCallibration = 0.5f;
    [SerializeField] private bool _hasAddRotation = true;
    [SerializeField] private bool _disableXRotation;

    protected void Update()
    {
        if (LookTarget == null)
        {
            return;
        }

        var lookPos = LookTarget.position - transform.position;
        lookPos.y = 0;
        var rotation = (lookPos != Vector3.zero) ? Quaternion.LookRotation(lookPos) : Quaternion.identity;

        if (_disableXRotation)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * _damping);
        }
        else
        {
            if (_hasAddRotation)
            {
                var addRotation = Quaternion.Euler(new Vector3(-LookTarget.eulerAngles.x, 
                    rotation.eulerAngles.y,
                    rotation.eulerAngles.z));
                rotation = Quaternion.Lerp(rotation, addRotation, _lerpFactorCallibration);
            }

            transform.rotation = Quaternion.Slerp(transform.rotation,
                new Quaternion(rotation.x, rotation.y, rotation.z, rotation.w), Time.deltaTime * _damping);
        }
    }
}
