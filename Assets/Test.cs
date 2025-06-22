using System;
using UnityEngine;

public class Boss
{
    private int hp = 100;   // 体力
    private int power = 25; // 攻撃力
    public int mp = 53;  //MP

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log( this.power + "のダメージを与えた" );
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }
    //魔法攻撃用の関数
       public void Magic()
    {
        // MPが5以上あるか確認
        if (this.mp >= 5)    
        {
            // MPを5減らす
            this.mp -= 5;
            // 魔法攻撃時のログを表示
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        // MPが5未満の場合 魔法を使えないログ表示。
            else
        {
            Debug.Log("MPがたりないため、魔法が使えない。");
        }
    }

}

public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // 課題メモ「要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください」
        //int arrayを5つ宣言
        int[] array = new int[5];

        // arrayに値を代入
        array[0] = 50;
        array[1] = 10;
        array[2] = 30;
        array[3] = 20;
        array[4] = 40;
        
        // 課題メモ「for文を使い、配列の各要素の値を順番に表示してください」
        // arrayの値を配列した順に表示
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        // 課題メモ「for文を使い、配列の各要素の値を逆順に表示してください」
        // arrayの値を逆順に表示
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }


        // Bossクラスから魔法攻撃を呼び出す
        Boss testboss = new Boss ();
        // Magicを繰り返し使い結果をDebug.logに表示する
        for (int i = 0; i < 10; i++)
        {
            testboss.Magic();
        }

        // Bossクラスから魔法攻撃を呼び出す
        {
        testboss.Magic();
        }
}
        // Update is called once per frame
        void Update()

        {

        }
}