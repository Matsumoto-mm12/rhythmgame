using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgmentArea : MonoBehaviour
{
    //�m�[�c�������Ă����Ƃ��ɁA�L�[�{�[�h���������画�肵����
    //�L�[����
    //�߂��Ƀm�[�c������̂�:Ray���Ƃ΂��ē���������߂�
    //�ǂꂭ�炢�̋߂��Ȃ̂� => �]��
    [SerializeField] float radius;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("a�����");
            RaycastHit2D hit2D = Physics2D.CircleCast(transform.position, 5, Vector3.zero);
            if (hit2D)
            {
                //Debug.Log("�m�[�c���Ԃ�����");
                float distance = Mathf.Abs(hit2D.transform.position.y - transform.position.y); //��Βl
                if(distance < 3)
                {
                    Debug.Log("great!");
                }
                else if (distance < 5)
                {
                    Debug.Log("good");
                }
                else
                {
                    Debug.Log("bad");
                }
                //�Ԃ��������̂�j�󂷂�
                Destroy(hit2D.collider.gameObject);
            }
        }
    }

    //����
    void OnDrawGizmosSelected()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, 5);
        
    }
}
