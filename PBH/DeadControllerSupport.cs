using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class DeadControllerSupport : MonoBehaviour
{
// this is simple
    public Transform Point;

    private readonly List<InputDevice> connectedLeftControllers = new List<InputDevice>();

    private static readonly InputDeviceCharacteristics LeftControllerFlags =
        InputDeviceCharacteristics.Controller | InputDeviceCharacteristics.Left;

    private void Update()
    {
        connectedLeftControllers.Clear();
        InputDevices.GetDevicesWithCharacteristics(LeftControllerFlags, connectedLeftControllers);

        if (connectedLeftControllers.Count == 0)
            transform.SetPositionAndRotation(chestEmpty.position, chestEmpty.rotation);
    }
}
