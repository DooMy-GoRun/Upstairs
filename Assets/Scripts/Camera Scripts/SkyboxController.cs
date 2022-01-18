using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxController : MonoBehaviour
{
    [SerializeField] private float RotateSpeed = 10f;
    

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotateSpeed);
        RenderSettings.skybox.SetFloat("_Exposure", Mathf.PerlinNoise (1f, Time.time));
    }
}
