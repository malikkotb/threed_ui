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
        
    }
}
