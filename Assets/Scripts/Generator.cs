using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{

    [SerializeField] private int resolution = 1000;
    [SerializeField] private Terrain terrain;

    private void Start()
    {
        GenerationTerrain();
    }

    void GenerationTerrain()
    {
        /*Terrain terrain = FindObjectOfType<Terrain>();*/
        float[,] heights = new float[resolution, resolution];

        float k = 0;
        for (int i = 0; i < resolution; i++)
        {
            for (int j = 0; j < resolution; j++)
            {
                heights[i, j] = k;
                k += 0.01f;
            }
        }

        terrain.terrainData.size = new Vector3(resolution, resolution, resolution); //Устанавливаем размер карты
        terrain.terrainData.heightmapResolution = resolution; // Передаем разрешение (количество высот)
        terrain.terrainData.SetHeights(0,0, heights); // И, наконец, применяем нашу карту высот (heights)

    }

}

