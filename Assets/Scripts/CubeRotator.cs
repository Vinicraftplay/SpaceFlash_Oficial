using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotator : MonoBehaviour
{
    public float RotationSpeed = 30f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);

        // Teste
    }
}
