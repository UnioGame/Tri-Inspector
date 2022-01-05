﻿using UnityEditor;
using UnityEngine;

namespace TriInspector
{
    public static class TriEditorStyles
    {
        private const string BaseResourcesPath = "Packages/com.triinspector/Editor/Resources/";

        private static GUIStyle _headerBox;
        private static GUIStyle _contentBox;
        private static GUIStyle _box;

        public static GUIStyle HeaderBox
        {
            get
            {
                if (_headerBox == null)
                {
                    _headerBox = new GUIStyle
                    {
                        border = new RectOffset(2, 2, 2, 2),
                        normal =
                        {
                            background = LoadTexture("TriInspector_Header_Bg"),
                        },
                    };
                }

                return _headerBox;
            }
        }

        public static GUIStyle ContentBox
        {
            get
            {
                if (_contentBox == null)
                {
                    _contentBox = new GUIStyle
                    {
                        border = new RectOffset(2, 2, 2, 2),
                        normal =
                        {
                            background = LoadTexture("TriInspector_Content_Bg"),
                        },
                    };
                }

                return _contentBox;
            }
        }

        public static GUIStyle Box
        {
            get
            {
                if (_box == null)
                {
                    _box = new GUIStyle
                    {
                        border = new RectOffset(2, 2, 2, 2),
                        normal =
                        {
                            background = LoadTexture("TriInspector_Box_Bg"),
                        },
                    };
                }

                return _box;
            }
        }

        private static Texture2D LoadTexture(string name)
        {
            var path = EditorGUIUtility.isProSkin
                ? BaseResourcesPath + name + "_Dark.png"
                : BaseResourcesPath + name + ".png";

            return (Texture2D) EditorGUIUtility.Load(path);
        }
    }
}