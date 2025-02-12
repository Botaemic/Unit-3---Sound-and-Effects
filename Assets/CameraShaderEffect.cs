﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class CameraShaderEffect : MonoBehaviour
{
    [SerializeField] private Material _material = null;

    #region Unity Functions
    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, _material);
    }
    #endregion

}
