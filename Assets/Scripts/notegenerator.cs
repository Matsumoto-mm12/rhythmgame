using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notegenerator : MonoBehaviour
{
    [SerializeField] note notePrefab;
    //Note�𐶐�����
    //Prefab:Instantiate

    //private void Start() //�J�n���Ƀm�[�c�������
    //{
    //    SpawnNote();
    //}

    public void SpawnNote()
    {
        //Instantiate(�������������́A�ꏊ�A�p�x);
        Instantiate(notePrefab, new Vector3(0, 10, 0), Quaternion.identity);
    }

    //�e�X�g�p
    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        SpawnNote(); //�m�[�c����
    //    }
    //}
}
