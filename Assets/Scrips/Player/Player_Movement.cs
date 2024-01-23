using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public enum E_InputState { Keybourd, UI_Button }
    public E_InputState InputState = E_InputState.UI_Button;
    //---------------------------------------------

    [SerializeField] float Speed;
   
    void Update()
    {
        buttonHanle();

        KeyboardInputHandle();
    }



    #region Buttons
    public enum E_ButtonState { Left, Right, Up, Down, none }
    public E_ButtonState ButtonState = E_ButtonState.none;
    public void Button_Movement_Left(bool allowed)
    {
        if (allowed)
        {
            InputState = E_InputState.UI_Button;
            ButtonState = E_ButtonState.Left;
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
            print("Left");
        }
        else
        {
            ButtonState = E_ButtonState.none;
            InputState = E_InputState.Keybourd;
        }

    }
    public void Button_Movement_Right(bool allowed)
    {
        if (allowed)
        {
            InputState = E_InputState.UI_Button;
            ButtonState = E_ButtonState.Right;
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
            print("right");
        }
        else
        {
            ButtonState = E_ButtonState.none;
            InputState = E_InputState.Keybourd;
        }
    }
    public void Button_Movement_Up(bool allowed)
    {
        if (allowed)
        {
            InputState = E_InputState.UI_Button;
            ButtonState = E_ButtonState.Up;
            transform.Translate(Vector3.up * Speed * Time.deltaTime);
        }
        else
        {
            ButtonState = E_ButtonState.none;
            InputState = E_InputState.Keybourd;
        }
    }
    public void Button_Movement_Down(bool allowed)
    {
        if (allowed)
        {
            InputState = E_InputState.UI_Button;
            ButtonState = E_ButtonState.Down;

        }
        else
        {
            ButtonState = E_ButtonState.none;
            InputState = E_InputState.Keybourd;
        }
    }
    void buttonHanle()
    {
        switch (ButtonState)
        {
            case E_ButtonState.Down:
                transform.Translate(Vector3.down * Speed * Time.deltaTime);
                break;
            case E_ButtonState.Up:
                transform.Translate(Vector3.up * Speed * Time.deltaTime);
                break;
            case E_ButtonState.Right:
                transform.Translate(Vector3.right * Speed * Time.deltaTime);
                break;
            case E_ButtonState.Left:
                transform.Translate(Vector3.left * Speed * Time.deltaTime);
                break;

        }
    }
    #endregion

    #region Keyboard
    Vector3 KeyboardDirection;
    void KeyboardInputHandle()
    {
        if (InputState == E_InputState.Keybourd)
        {
            KeyboardDirection.x = Input.GetAxis("Horizontal");
            KeyboardDirection.y = Input.GetAxis("Vertical");
            transform.Translate(KeyboardDirection * Speed * Time.deltaTime);
        }
    }
    #endregion
}
