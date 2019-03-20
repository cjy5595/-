using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum CubeID { HEAD, BODY, LLEG, RLEG, LARM, RARM }


public class VoxelCharacter : MonoBehaviour {

    Mesh stMesh = new Mesh();
    MeshFilter stMeshFilter;
   
    private void Awake () // for initialization
    {
        stMeshFilter = GetComponent<MeshFilter>();
        stMeshFilter.mesh = stMesh;
    }
    // 8개의 정점       
    void VertexPoint(Vector3 vPos1, Vector3 vPos2 ,Vector3 vPos3, Vector3 vPos4,
                      Vector3 vPos5, Vector3 vPos6, Vector3 vPos7, Vector3 vPos8)
    {
        stMesh.vertices = new Vector3[]
       {
                //앞면
                new Vector3(vPos1.x,vPos1.y,vPos1.z),
                new Vector3(vPos1.x,vPos1.y,vPos1.z),
                new Vector3(vPos2.x,vPos2.y,vPos2.z),
                new Vector3(vPos2.x,vPos1.y,vPos2.z),
                //후면
                new Vector3(vPos5.x,vPos5.y,vPos5.z),
                new Vector3(vPos5.x,vPos6.y,vPos5.z),
                new Vector3(vPos6.x,vPos6.y,vPos6.z),
                new Vector3(vPos6.x,vPos5.y,vPos6.z),
                //좌측면
                new Vector3(vPos3.x,vPos3.y,vPos3.z),
                new Vector3(vPos3.x,vPos4.y,vPos3.z),
                new Vector3(vPos4.x,vPos4.y,vPos4.z),
                new Vector3(vPos4.x,vPos3.y,vPos4.z),
                //우측면
                new Vector3 (vPos7.x,vPos7.y,vPos7.z),
                new Vector3(vPos7.x,vPos8.y,vPos7.z),
                new Vector3(vPos8.x,vPos8.y,vPos8.z),
                new Vector3(vPos8.x,vPos7.y,vPos8.z),
                //상
                new Vector3(vPos4.x,vPos4.y,vPos4.z),
                new Vector3(vPos4.x,vPos8.y,vPos8.z),
                new Vector3(vPos8.x,vPos8.y,vPos8.z),
                new Vector3(vPos8.x,vPos4.y,vPos4.z),
                //하
                new Vector3(vPos3.x,vPos3.y,vPos3.z),
                new Vector3(vPos3.x,vPos7.y,vPos7.z),
                new Vector3(vPos7.x,vPos7.y,vPos7.z),
                new Vector3(vPos7.x,vPos3.y,vPos3.z),
       };

        stMesh.triangles = new int[]
       {
            0, 1, 2,
            2, 3, 0,
            4, 5, 6,
            4, 6, 7,
            8, 9, 10,
            8, 10 ,11,
            12, 13, 14,
            12, 14, 15,
            16, 17, 18,
            16, 18, 19,
            20, 21, 22,
            20, 22, 23
       };
    }

    void UV_MapPing(Vector2 vPos1, Vector2 vPos2, Vector2 vPos3, Vector2 vPos4, Vector2 vPos5, Vector2 vPos6,
        Vector2 vPos7, Vector2 vPos8, Vector2 vPos9, Vector2 vPos10, Vector2 vPos11, Vector2 vPos12)
    {
        stMesh.uv = new Vector2[] { vPos1, new Vector2(vPos1.x , vPos2.y), vPos2,  new Vector2(vPos2.x, vPos1.y), //앞면
                                    vPos5, new Vector2(vPos5.x, vPos6.y),  vPos6, new Vector2(vPos6.x, vPos5.y) , //뒷면
                                    vPos3, new Vector2(vPos3.x, vPos4.y) , vPos4, new Vector2(vPos4.x, vPos3.y), //좌측면
                                    vPos7, new Vector2(vPos7.x , vPos8.y), vPos8 , new Vector2(vPos8.x, vPos7.y), //우측
                                    vPos9, new Vector2(vPos9.x , vPos10.y), vPos10 , new Vector2(vPos10.x, vPos9.y),
                                    vPos11, new Vector2(vPos11.x , vPos12.y), vPos12 , new Vector2(vPos12.x, vPos11.y),
        };
    }

    public Mesh Cube(CubeID eID,  Vector3 vPos,  Vector3 vInfo)
    {
        VertexPoint(new Vector3(-vInfo.x, -vInfo.y, -vInfo.z) + vPos,
                    new Vector3(-vInfo.x, -vInfo.y, vInfo.z) + vPos,
                    new Vector3(vInfo.x, vInfo.y, -vInfo.z) + vPos,
                    new Vector3(-vInfo.x, vInfo.y, -vInfo.z) + vPos,

                    new Vector3(vInfo.x, -vInfo.y, vInfo.z) + vPos, //
                    new Vector3(-vInfo.x, vInfo.y, vInfo.z) + vPos,
                    new Vector3(vInfo.x, vInfo.y, vInfo.z) + vPos,
                    new Vector3(vInfo.x, vInfo.y, vInfo.z) + vPos);
        switch (eID)
        {
            case CubeID.HEAD:
                UV_MapPing(new Vector2(0.125f, 0.75f), new Vector2(0.25f, 0.875f), new Vector2(0.375f, 0.75f), new Vector2(0.25f, 0.875f),
                    new Vector2(0.375f, 0.75f), new Vector2(0.5f, 0.875f), new Vector2(0.125f, 0.75f), new Vector2(0, 0.875f),
                    new Vector2(0.125f, 0.875f), new Vector2(0.25f, 1.0f), new Vector2(0.25f, 0.875f), new Vector2(0.375f, 1.0f));
                break;
          
            case CubeID.BODY:
                UV_MapPing(new Vector2(0.3125f, 0.5f), new Vector2(0.4375f, 0.6875f), new Vector2(0.5625f, 0.5f), new Vector2(0.625f, 0.6875f),
                    new Vector2(0.4375f, 0.5f), new Vector2(0.5625f, 0.6875f), new Vector2(0.25f, 0.5f), new Vector2(0.3125f, 0.6875f),
                    new Vector2(0.3125f, 0.6875f), new Vector2(0.4375f, 0.75f), new Vector2(0.4375f, 0.6875f), new Vector2(0.5625f, 0.75f));
                break;

            case CubeID.LARM:
                UV_MapPing(new Vector2(0.5f, 0f), new Vector2(0.5625f, 0.1875f), new Vector2(0.5625f, 0f), new Vector2(0.625f, 0.1875f),
                    new Vector2(0.625f, 0f), new Vector2(0.6875f, 0.1875f), new Vector2(0.4375f, 0f), new Vector2(0.5f, 0.1875f),
                    new Vector2(0.5625f, 0.1875f), new Vector2(0.625f, 0.25f), new Vector2(0.625f, 0.1875f), new Vector2(0.6875f, 0.25f));
                break;
            case CubeID.RARM:
                UV_MapPing(new Vector2(0.6875f, 0.5f), new Vector2(0.75f, 0.6875f), new Vector2(0.75f, 0.5f), new Vector2(0.8125f, 0.6875f),
                    new Vector2(0.8125f, 0.5f), new Vector2(0.875f, 0.6875f), new Vector2(0.625f, 0.5f), new Vector2(0.6875f, 0.6875f),
                    new Vector2(0.6875f, 0.6875f), new Vector2(0.75f, 0.75f), new Vector2(0.75f, 0.6875f), new Vector2(0.8125f, 0.75f));
                break;

            case CubeID.LLEG:
                UV_MapPing(new Vector2(0.3125f, 0f), new Vector2(0.375f, 0.1875f), new Vector2(0.375f, 0f), new Vector2(0.4375f, 0.1875f),
                    new Vector2(0.4375f, 0f), new Vector2(0.5f, 0.1875f), new Vector2(0.25f, 0f), new Vector2(0.3125f, 0.1875f),
                    new Vector2(0.3125f, 0.1875f), new Vector2(0.375f, 0.25f), new Vector2(0.375f, 0.1875f), new Vector2(0.4375f, 0.25f));
                break;

            case CubeID.RLEG:
                UV_MapPing(new Vector2(0.0625f, 0.5f), new Vector2(0.125f, 0.6875f), new Vector2(0.125f, 0.5f), new Vector2(01875f, 0.6875f),
                    new Vector2(0.1875f, 0.5f), new Vector2(0.25f, 0.6875f), new Vector2(0f, 0.5f), new Vector2(0.0625f, 0.6875f),
                    new Vector2(0.0625f, 0.6875f), new Vector2(0.125f, 0.75f), new Vector2(0.125f, 0.6875f), new Vector2(0.1875f, 0.75f));
                break;

        }

        return stMesh;
    }
    // Update is called once per frame
    private void Update ()
    {
		
	}
}
