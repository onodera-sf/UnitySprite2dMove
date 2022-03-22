using UnityEngine;
using UnityEngine.InputSystem;  // �ǉ�

public class SpriteMove : MonoBehaviour
{
  // ��莞�Ԃ��ƂɌĂ΂�܂�
  void FixedUpdate()
  {
    // �L�[�{�[�h�̏����擾
    var keyboard = Keyboard.current;
    if (keyboard == null)
    {
      Debug.Log("�L�[�{�[�h������܂���B");
      return;
    }

    // �X�v���C�g�̈ړ�����
    // Translate ���\�b�h�ŃX�v���C�g�̈ʒu���ړ����܂�
    // Space.World ���w�肷��Ɖ�]�̉e���������܂���
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

    // �X�v���C�g�̉�]����
    // Rotate ���\�b�h�ŃX�v���C�g����]���܂�
    if (keyboard.spaceKey.isPressed)
    {
      transform.Rotate(0, 0, 5f);
    }

    // �X�v���C�g�̊g��k��
    // ���\�b�h�͂Ȃ��̂� localScale �v���p�e�B�ɔ{���������܂�
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
