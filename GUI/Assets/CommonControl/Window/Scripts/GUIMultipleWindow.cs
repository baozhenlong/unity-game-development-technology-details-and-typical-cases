using UnityEngine;

public class GUIMultipleWindow : MonoBehaviour
{
    [Tooltip("窗口 1 的矩形区域")]
    public Rect clientRect1 = new(20f, 20f, 120f, 50f);
    [Tooltip("窗口 2 的矩形区域")]
    public Rect clientRect2 = new(20f, 100f, 120f, 50f);

    private void OnGUI()
    {
        // 绘制多个窗口
        GUI.color = Color.red;
        clientRect1 = GUI.Window(0, clientRect1, DoMyWindow, "Red Window");
        GUI.color = Color.green;
        clientRect2 = GUI.Window(1, clientRect2, DoMyWindow, "Green Window");
    }

    private void DoMyWindow(int windowID)
    {
        // 创建一个按钮
        if (GUI.Button(new Rect(10f, 25f, 100f, 20f), "Hello World"))
        {
            print("Got a click in window " + windowID);
        }
        // 在自定义的矩形区域绘制一个可拖动窗口
        GUI.DragWindow(new Rect(0.0f, 0.0f, 10000, 10000));
    }
}
