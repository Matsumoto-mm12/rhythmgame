using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note : MonoBehaviour
{
    //���ɗ�����
    // TODO: �����鑬�x���ȂƔ���ꏊ�Ƃ̋�������ݒ肷��K�v������
    float speed;

    private void Start()
    {
        speed = 20;
    }
    void Update()
    {
        transform.Translate(0, -20 * Time.deltaTime, 0);
    }
}
