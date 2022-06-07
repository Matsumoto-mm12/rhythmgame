using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notegenerator : MonoBehaviour
{
    [SerializeField] note notePrefab;
    //Noteを生成する
    //Prefab:Instantiate

    //private void Start() //開始時にノーツが流れる
    //{
    //    SpawnNote();
    //}

    public void SpawnNote()
    {
        //Instantiate(生成したいもの、場所、角度);
        Instantiate(notePrefab, new Vector3(0, 10, 0), Quaternion.identity);
    }

    //テスト用
    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        SpawnNote(); //ノーツ生成
    //    }
    //}
}
