using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(MeshFilter))]
public class TrailCreation : MonoBehaviour
{


    Mesh mesh;
    Vector3[] vertices;

    public Vector3 bLeft;
    public Vector3 tLeft;
    public Vector3 bRight;
    public Vector3 tRight;

    int[] triangles;

    private void Awake()
    {
        mesh = GetComponent<MeshFilter>().mesh;
    }
    // Use this for initialization
    void Start()
    {
        MakeMeshData();
        CreateMesh();

    }
    private void Update()
    {

    }


    void MakeMeshData()
    {
        //create array of vertices
        vertices = new Vector3[] { new Vector3(0, 0, 0), new Vector3(0, 0, 1), new Vector3(1, 0, 0) };

        //creates array of integers

        triangles = new int[] { 0, 1, 2 };
    }

    void CreateMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;

    }


}
