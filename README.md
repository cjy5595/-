# -
저장소 설명
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CTri : MonoBehaviour
{

    public Transform[] bones;
    SkinnedMeshRenderer smr;

    // Use this for initialization
    void Start()
    {
        Mesh m = new Mesh();

        m.vertices = new Vector3[]
            {
                //n
                new Vector2(-1,9),
                new Vector2(1,9),
                new Vector2(0,7),
                //s
                new Vector2(-1,7),
                new Vector2(1,7),
                new Vector2(0,5),
                //p
                new Vector2(-1,5),
                new Vector2(1,5),
                new Vector2(0,3),
                //ll
                new Vector2(-1.5f,4),
                new Vector2(-0.5f,4),
                new Vector2(-1,2),
                //lk
                new Vector2(-1.5f,2),
                new Vector2(-0.5f,2),
                new Vector2(-1,0),
                //rl
                new Vector2(0.5f,4),
                new Vector2(1.5f,4),
                new Vector2(1,2),
                //rk
                new Vector2(0.5f,2),
                new Vector2(1.5f,2),
                new Vector2(1,0),
                //ls
                new Vector2(-3,6.5f),
                new Vector2(-1,7),
                new Vector2(-1,6),
                //lr
                new Vector2(-5,6.5f),
                new Vector2(-3,7),
                new Vector2(-3,6),
                //rs
                new Vector2(3,6.5f),
                new Vector2(1,6),
                new Vector2(1,7),
                //ra
                new Vector2(5,6.5f),
                new Vector2(3,6),
                new Vector2(3,7)
            };

        m.triangles = new int[]
            {
                0,1,2,
                3,4,5,
                6,7,8,
                9,10,11,
                12,13,14,
                15,16,17,
                18,19,20,
                21,22,23,
                24,25,26,
                27,28,29,
                30,31,32
            };


        m.bindposes = new Matrix4x4[]
            {
                bones[0].worldToLocalMatrix * transform.localToWorldMatrix,
                bones[1].worldToLocalMatrix * transform.localToWorldMatrix,
                bones[2].worldToLocalMatrix * transform.localToWorldMatrix,
                bones[3].worldToLocalMatrix * transform.localToWorldMatrix,
                bones[4].worldToLocalMatrix * transform.localToWorldMatrix,
                bones[5].worldToLocalMatrix * transform.localToWorldMatrix,
                bones[6].worldToLocalMatrix * transform.localToWorldMatrix,
                bones[7].worldToLocalMatrix * transform.localToWorldMatrix,
                bones[8].worldToLocalMatrix * transform.localToWorldMatrix,
                bones[9].worldToLocalMatrix * transform.localToWorldMatrix,
                bones[10].worldToLocalMatrix * transform.localToWorldMatrix,
            };
        m.boneWeights = new BoneWeight[]
        {
            //neck
            new BoneWeight(){boneIndex0 =0, weight0 = 1f},
            new BoneWeight(){boneIndex0 =0, weight0 = 1f},
            new BoneWeight(){boneIndex0 =0, weight0 = 1f},
            //spin
            new BoneWeight(){boneIndex0 =1, weight0 = 0.9f},
            new BoneWeight(){boneIndex0 =1, weight0 = 0.9f},
            new BoneWeight(){boneIndex0 =1, weight0 = 0.9f},
            //pel
            new BoneWeight(){boneIndex0 =2, weight0 = 0.9f},
            new BoneWeight(){boneIndex0 =2, weight0 = 0.9f},
            new BoneWeight(){boneIndex0 =2, weight0 = 0.9f},
            //lleg
            new BoneWeight(){boneIndex0 =3, weight0 = 1f},
            new BoneWeight(){boneIndex0 =3, weight0 = 1f},
            new BoneWeight(){boneIndex0 =3, weight0 = 1f},
            //lke
            new BoneWeight(){boneIndex0 =4, weight0 = 1f},
            new BoneWeight(){boneIndex0 =4, weight0 = 1f},
            new BoneWeight(){boneIndex0 =4, weight0 = 1f},
            //rlen
            new BoneWeight(){boneIndex0 =5, weight0 = 1f},
            new BoneWeight(){boneIndex0 =5, weight0 = 1f},
            new BoneWeight(){boneIndex0 =5, weight0 = 1f},
            //rkn
            new BoneWeight(){boneIndex0 =6, weight0 = 1f},
            new BoneWeight(){boneIndex0 =6,weight0 = 1f},
            new BoneWeight(){boneIndex0 =6, weight0 = 1f},
            //lsh
            new BoneWeight(){boneIndex0 =7, weight0 = 1f},
            new BoneWeight(){boneIndex0 =7, weight0 = 1f},
            new BoneWeight(){boneIndex0 =7, weight0 = 1f},
            //lar
            new BoneWeight(){boneIndex0 =8, weight0 = 1f},
            new BoneWeight(){boneIndex0 =8, weight0 = 1f},
            new BoneWeight(){boneIndex0 =8, weight0 = 1f},
            //rsh
            new BoneWeight(){boneIndex0 =9, weight0 = 1f},
            new BoneWeight(){boneIndex0 =9, weight0 = 1f},
            new BoneWeight(){boneIndex0 =9, weight0 = 1f},
            //rar
            new BoneWeight(){boneIndex0 =10, weight0 = 1f},
            new BoneWeight(){boneIndex0 =10, weight0 = 1f},
            new BoneWeight(){boneIndex0 =10, weight0 = 1f},

        };


        smr = GetComponent<SkinnedMeshRenderer>();
        smr.bones = bones;
        smr.sharedMesh = m;
        smr.quality = SkinQuality.Bone2;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
