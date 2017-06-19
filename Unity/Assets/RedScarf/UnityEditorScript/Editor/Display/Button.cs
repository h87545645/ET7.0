﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/// <summary>
/// 按钮
/// </summary>
public class UESButton : UESDisplayObject
{
    protected string m_Text;
    protected GUIContent m_Content;
    protected Texture m_Image;
    protected GUIStyle m_Style;
    protected int drawingStyle;

    protected override void Awake()
    {
        base.Awake();
        SetDrawingStyle("Button");
    }

    public override void OnGUI()
    {
        switch (drawingStyle)
        {
            case 1:
                GUI.Button(m_DrawingRect, m_Content);
                break;

            case 2:
                GUI.Button(m_DrawingRect, m_Text);
                break;

            case 3:
                GUI.Button(m_DrawingRect, m_Image);
                break;

            case 4:
                GUI.Button(m_DrawingRect, m_Content, m_Style);
                break;

            case 5:
                GUI.Button(m_DrawingRect, m_Text, m_Style);
                break;

            case 6:
                GUI.Button(m_DrawingRect, m_Image, m_Style);
                break;
        }
    }

    public void SetDrawingStyle(GUIContent content)
    {
        drawingStyle = 1;

        m_Content = content;
    }

    public void SetDrawingStyle(string text)
    {
        drawingStyle = 2;

        m_Text = text;
    }

    public void SetDrawingStyle(Texture image)
    {
        drawingStyle = 3;

        m_Image = image;
    }

    public void SetDrawingStyle(GUIContent content, GUIStyle style)
    {
        drawingStyle = 4;

        m_Content = content;
        m_Style = style;
    }

    public void SetDrawingStyle(string text, GUIStyle style)
    {
        drawingStyle = 5;

        m_Text = text;
        m_Style = style;
    }

    public void SetDrawingStyle(Texture image, GUIStyle style)
    {
        drawingStyle = 6;

        m_Image = image;
        m_Style = style;
    }
}