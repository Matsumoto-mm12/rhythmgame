using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class GameManager : MonoBehaviour
{
    //�Q�[���J�n�̎���
    //�R���[�`�����g���F���Ԃ𐧌䂵����
    //�Q�[���I���̎����F�^�C�����C���̏I�������m����
    //�V�O�i���isignal�j���g��
    //UI�̍쐬
    //�J�E���g�_�E���e�L�X�g
    //�Q�[���I���̃��U���g�p�l��
    //�Q�[�����̃X�R�A�\��
    //�^�C�g����
    //���g���C�{�^��

    //�^�C�����C�����Đ�������
    [SerializeField] PlayableDirector playableDirector;

    void Start()
    {
        StartCoroutine(GameMain());
    }

    IEnumerator GameMain()
    {
        Debug.Log("3");
        yield return new WaitForSeconds(1);
        Debug.Log("2");
        yield return new WaitForSeconds(1);
        Debug.Log("1");
        yield return new WaitForSeconds(1);
        Debug.Log("start");
        yield return new WaitForSeconds(0.3f);
        playableDirector.Play();
        
    }

    public void OnEndEvent()
    {
        Debug.Log("�Q�[���I���F���ʕ\��");
    }
}
