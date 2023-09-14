using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    private Transform _rotator;

    [SerializedField] private float smoothing = 0.1f;
    void Start()
    {
        InputSystem.EnableDevice(AttitudeSensor.current)
        _rotator = new GameObject("Rotator").transform;
        var localTransform = transform;
        _rotator.SetPositioonAndRotation(localTransform.position, localTransform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        LookAround();
    }

    private void LookAround() 
    {
        Quaternion attitude = AttitudeSensor.current.attitude.ReadValue();
        _rotator.rotation = attitude;

        // change rotation of _rotator object because the intrinsic coord. system of our smartphone is not aligned with 
        // with the coordinate system of our virtual camera object  
        _rotator.Rotate(0f, 0f, 180f, Space.self);
        _rotator.Rotate(90f, 180f, 0f, Space.World);

        // interpolate between the rotation, the player controller has, and the rotation the phone has
        transform.rotation = Quaternion.Slerp(transform.rotation, _rotator.rotation, smoothing);

    }
}
