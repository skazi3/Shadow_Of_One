using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(MeshFilter))]
public class TrailCreation : MonoBehaviour
{ 
    Mesh mesh;
    Vector3[] vertices;
    List<Vector3> verticeList;
    int[] triangles;
    List<int> triangleList;

    public int trailWidth;
    
    public GameObject player;
    

    public Vector3 bLeft;
    public Vector3 tLeft;
    public Vector3 bRight;
    public Vector3 tRight;
    public Vector3 playerPos;
    
    private int i = 0;


    public int updateLength;

    private void Awake()
    {
        trailWidth = 1;
        mesh = GetComponent<MeshFilter>().mesh;
        
        //mesh.gameObject.AddComponent<MeshCollider>();
        playerPos = player.GetComponent<Transform>().position;
        verticeList = new List<Vector3>();
        triangleList = new List<int>();
        bLeft = new Vector3(playerPos.x- trailWidth, playerPos.y-.5f, playerPos.z-1);
        tLeft = new Vector3(playerPos.x - trailWidth, playerPos.y-.5f, playerPos.z-.5f);
        bRight = new Vector3(playerPos.x + trailWidth, playerPos.y-.5f, playerPos.z - 1);
        tRight = new Vector3(playerPos.x + trailWidth, playerPos.y-.5f, playerPos.z-.5f);

        MakeMeshData();
        CreateMesh();
    }

    private void Update()
    {
        playerPos = player.GetComponent<Transform>().position;
        UpdateVertices();
        CreateMesh();
        MeshCollider mesh_collider = GetComponent<MeshCollider>();
        mesh_collider.sharedMesh = mesh;


    }
    


    void MakeMeshData()
    {
        //create array of vertices
        //vertices = new Vector3[] { bLeft, tLeft, bRight, tRight };
        verticeList.Add(bLeft);
        verticeList.Add(tLeft);
        verticeList.Add(bRight);
        verticeList.Add(tRight);
        vertices = verticeList.ToArray();
        //creates array of integers
        triangleList.Add(i);
        triangleList.Add(i + 1);
        triangleList.Add(i + 2);
        triangleList.Add(i + 2);
        triangleList.Add(i + 1);
        triangleList.Add(i + 3);
        triangles = triangleList.ToArray();
        //triangles = new int[] { i, i+1, i+2, i+2, i+1, i+3 };
    }

    void CreateMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
    }

    void UpdateVertices()
    {
        bLeft = tLeft;
        bRight = tRight;
        tLeft = new Vector3(playerPos.x - trailWidth, playerPos.y-.5f, playerPos.z-.5f);
        tRight = new Vector3(playerPos.x + trailWidth, playerPos.y - .5f, playerPos.z-.5f);
        Vector3 newBLeft = new Vector3(bLeft.x, bLeft.y, bLeft.z);
        Vector3 newBRight = new Vector3(bRight.x, bRight.y, bRight.z);
        Vector3 newTRight = new Vector3(tRight.x, tRight.y, tRight.z);
        Vector3 newTLeft = new Vector3(tLeft.x, tLeft.y, tLeft.z);

        verticeList.Add(newBLeft);
        verticeList.Add(newTLeft);
        verticeList.Add(newBRight);
        verticeList.Add(newTRight);
        vertices = verticeList.ToArray();
        i += 4;
        triangleList.Add(i);
        triangleList.Add(i+1);
        triangleList.Add(i+2);
        triangleList.Add(i+2);
        triangleList.Add(i+1);
        triangleList.Add(i+3);
        triangles = triangleList.ToArray();
    }


}
