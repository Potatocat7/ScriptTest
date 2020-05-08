using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    //課題：int型の変数mpを宣言し、53で初期化してください
    //課題：pを消費して魔法攻撃をするMagic関数を作ってください
    //課題：Magic関数内でmpを5減らし、コンソールに「魔法攻撃をした。残りMPは〇〇。」と表示してください。mpが足りない場合、「MPが足りないため魔法が使えない。」と表示してください

    //※発展課題：Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; // 課題：マジックポイント

    //課題： 魔法の関数
    public void Magic()
    {
        if(mp < 5)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        else
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }
    }

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

}

public class Test : MonoBehaviour {

    void Start()
    {
        //要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
        int[] array = {1,2,3,5,7 };
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //課題：for文を使い、配列の各要素の値を順番に表示してください
        for (int count=0; count < 5; count++)
        {
            Debug.Log(array[count]);
        }
        //課題：for文を使い、配列の各要素の値を逆順に表示してください    
        for (int count = 4; count >= 0; count--)
        {
            Debug.Log(array[count]);
        }

        //課題：Magic関数を呼び出して、魔法を使ってください
        for (int count = 0; count < 10 ; count++)
        {
            lastboss.Magic();
        }
        //課題：Magic関数を10回使った後に、更にMagic関数を呼び出すと、mpが足りないメッセージが表示されることを確認してください
        lastboss.Magic();



    }

    // Update is called once per frame
    void Update () {
		
	}
}
