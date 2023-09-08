using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    Transform camTransform;

    public float sensitivity = 0.1f;

    Vector2 camRotation;

    Vector3 walkVector;
    Vector3 realWalkVector;

    void Start()
    {
        camTransform = Camera.main.transform;
    }

    void Update()
    {
        if (Keyboard.current.wKey.wasPressedThisFrame) walkVector.z++;
        if (Keyboard.current.wKey.wasReleasedThisFrame) walkVector.z--;
        if (Keyboard.current.sKey.wasPressedThisFrame) walkVector.z--;
        if (Keyboard.current.sKey.wasReleasedThisFrame) walkVector.z++;

        if (Keyboard.current.aKey.wasPressedThisFrame) walkVector.x--;
        if (Keyboard.current.aKey.wasReleasedThisFrame) walkVector.x++;
        if (Keyboard.current.dKey.wasPressedThisFrame) walkVector.x++;
        if (Keyboard.current.dKey.wasReleasedThisFrame) walkVector.x--;

        realWalkVector = Vector3.LerpUnclamped(realWalkVector, walkVector, 10 * Time.deltaTime);

        // Mouselook
        camRotation = Mouse.current.delta.value * sensitivity;
    }

    void LateUpdate()
    {
        transform.Translate(realWalkVector);
    }
}