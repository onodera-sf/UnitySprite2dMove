using UnityEngine;
using UnityEngine.InputSystem;  // 追加

public class SpriteMove : MonoBehaviour
{
  // 一定時間ごとに呼ばれます
  void FixedUpdate()
  {
    // キーボードの情報を取得
    var keyboard = Keyboard.current;
    if (keyboard == null)
    {
      Debug.Log("キーボードがありません。");
      return;
    }

    // スプライトの移動処理
    // Translate メソッドでスプライトの位置が移動します
    // Space.World を指定すると回転の影響をうけません
    if (keyboard.leftArrowKey.isPressed)
    {
      transform.Translate(-0.1f, 0, 0, Space.World);
    }
    if (keyboard.rightArrowKey.isPressed)
    {
      transform.Translate(0.1f, 0, 0, Space.World);
    }
    if (keyboard.upArrowKey.isPressed)
    {
      transform.Translate(0, 0.1f, 0, Space.World);
    }
    if (keyboard.downArrowKey.isPressed)
    {
      transform.Translate(0, -0.1f, 0, Space.World);
    }

    // スプライトの回転処理
    // Rotate メソッドでスプライトが回転します
    if (keyboard.spaceKey.isPressed)
    {
      transform.Rotate(0, 0, 5f);
    }

    // スプライトの拡大縮小
    // メソッドはないので localScale プロパティに倍率をかけます
    if (keyboard.aKey.isPressed)
    {
      transform.localScale *= 1.02f;
    }
    if (keyboard.zKey.isPressed)
    {
      transform.localScale /= 1.02f;
    }
  }
}
