﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CSharpGL
{
    /// <summary>
    /// build texture's content with IntPtr.Zero.
    /// </summary>
    public class NullImageBuilder : ImageBuilder
    {
        private int width;
        private int height;
        private uint internalFormat;
        private uint format;
        private uint type;

        /// <summary>
        /// build texture's content with IntPtr.Zero.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="internalFormat"></param>
        /// <param name="format"></param>
        /// <param name="type"></param>
        public NullImageBuilder(int width, int height, uint internalFormat, uint format, uint type)
        {
            this.width = width;
            this.height = height;
            this.internalFormat = internalFormat;
            this.format = format;
            this.type = type;
        }
        /// <summary>
        /// 
        /// </summary>
        public override void Build()
        {
            OpenGL.TexImage2D((uint)BindTextureTarget.Texture2D, 0,
                internalFormat,// OpenGL.GL_RGBA, 
                width, height, 0,
                this.format,// OpenGL.GL_RGBA,
                this.type,// OpenGL.GL_UNSIGNED_BYTE, 
                IntPtr.Zero);
        }
    }
}
