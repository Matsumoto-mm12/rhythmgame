using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class GameManager : MonoBehaviour
{
    //ゲーム開始の実装
    //コルーチンを使う：時間を制御したい
    //ゲーム終了の実装：タイムラインの終了を検知する
    //シグナル（signal）を使う
    //UIの作成
    //カウントダウンテキスト
    //ゲーム終了のリザルトパネル
    //ゲーム中のスコア表示
    //タイトルへ
    //リトライボタン

    //タイムラインを再生したい
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
        Debug.Log("ゲーム終了：結果表示");
    }
}
